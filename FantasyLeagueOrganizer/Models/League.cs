using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer.Models
{
	public class League
	{
		public string Name { get; set; }
		public Guid Id { get; set; }
		public string DisplayNameItemSingular { get; set; } = "Item";
		public string DisplayNameItemPlural { get; set; } = "Items";
		public string DisplayNameCategorySingular { get; set; } = "Category";
		public string DisplayNameCategoryPlural { get; set; } = "Categories";
		public string DisplayNameTeamSingular { get; set; } = "Team";
		public string DisplayNameTeamPlural { get; set; } = "Teams";
		public int WinPointValue { get; set; } = 3;
		public int LossPointValue { get; set; } = 0;
		public int TiePointValue { get; set; } = 1;

		public DraftOrderStyle DraftStyle { get; set; } = DraftOrderStyle.Snake;
		public enum DraftOrderStyle
		{
			Snake,
			Linear
		}
		public int DraftRoundCount { get; set; } = 1;


		/// <summary>
		/// All teams in the league
		/// </summary>
		public List<Team> Teams { get; set; } = new();

		/// <summary>
		/// Ranked list of teams, sorted by: Points => H2H => Most Wins => Fewest Losses => Alphabetical
		/// </summary>
		[NotMapped]
		public List<Team> TeamsRanked
		{
			get
			{
				// First, sort by everything except head-to-head
				var teamsGroupedByPoints = Teams.GroupBy(t => t.Points).OrderByDescending(g => g.Key);

				var rankedTeams = new List<Team>();

				foreach (var pointGroup in teamsGroupedByPoints)
				{
					// If only one team in this point tier, no need for tiebreakers
					if (pointGroup.Count() == 1)
					{
						rankedTeams.Add(pointGroup.First());
						continue;
					}

					// Multiple teams with same points - apply tiebreakers
					var tiedTeams = pointGroup.ToList();

					// Try to break ties with head-to-head
					var sortedByHeadToHead = SortByHeadToHead(tiedTeams);

					// Then apply remaining tiebreakers
					var finalSort = sortedByHeadToHead
						.ThenByDescending(t => t.Wins)
						.ThenBy(t => t.Losses)
						.ThenBy(t => t.Name);

					rankedTeams.AddRange(finalSort);
				}

				return rankedTeams;
			}
		}

		/// <summary>
		/// All items in the league, including ones not assigned to teams
		/// </summary>
		public HashSet<Item> Items { get; set; } = new();

		/// <summary>
		/// List of all categories to which an item can belong
		/// </summary>
		public List<Category> Categories { get; set; } = new();

		public List<MatchupRegularSeason> MatchupsRegularSeason { get; set; } = new();

		public List<MatchupPlayoffs> MatchupsPlayoffs { get; set; } = new();

		public List<RankingProvider> RankingProviders { get; set; } = new();

		[NotMapped]
		public List<Item> FreeAgents => Items.Where(i => i.TeamId == null).ToList();

		public League() : this("New League") { }

		public League(string name)
		{
			Name = name;
			Id = Guid.NewGuid();
		}

		public override string ToString()
		{
			return $"[League] {Name}";
		}

		//public void AddTeam(Team team)
		//{
		//	Teams.Add(team);
		//}

		//public void AddItem(Item item)
		//{
		//	Items.Add(item);
		//}

		//public void AddCategory(Category category)
		//{
		//	Categories.Add(category);
		//}

		//public void AddMatchupRegularSeason(MatchupRegularSeason matchup)
		//{
		//	MatchupsRegularSeason.Add(matchup);
		//}

		//public void AddMatchupPlayoffs(MatchupPlayoffs matchup)
		//{
		//	MatchupsPlayoffs.Add(matchup);
		//}

		//public void AddRankingProvider(RankingProvider provider)
		//{
		//	RankingProviders.Add(provider);
		//}

		public bool ContainsTeam(string name)
		{
			return Teams.Any(t => t.Name == name);
		}

		public bool ContainsTeam(Guid id)
		{
			return Teams.Any(t => t.Id == Id);
		}

		public Team? GetTeam(string name)
		{
			return Teams.FirstOrDefault(t => t.Name == name);
		}

		public bool ContainsItemWithName(string name)
		{
			return Items.Any(i => i.Name == name);
		}

		public bool ContainsItem(Guid id)
		{
			return Items.Any(i => i.Id == id);
		}

		public Item? GetItem(string name)
		{
			return Items.FirstOrDefault(i => i.Name == name);
		}

		public void RemoveItem(Item item)
		{
			if (!Items.Contains(item))
			{
				throw new ArgumentException($"The item ({item.Name}) does not exist in this league ({Name})");
			}

			//Remove the item from all of its categories
			//foreach (var category in item.ValidCategories)
			//{
			//	category.RemoveItem(item);
			//}

			//Just delete the item from our list now
			//Since the info about what team the item is on, whether it's in a lineup, etc. it all stored within the item object,
			//we don't need to worry about deleting it from any team
			Items.Remove(item);
		}

		public void RemoveCategory(Category category)
		{
			if (!Categories.Contains(category))
			{
				throw new ArgumentException($"The category ({category.Name}) does not exist in this league ({Name})");
			}

			//remove the category from the validCategories list of all items that belong to it
			foreach (var item in category.Items)
			{
				item.RemoveCategory(category);
			}

			Categories.Remove(category);
		}

		public void RemoveTeam(Team team)
		{
			if (!Teams.Contains(team))
			{
				throw new ArgumentException($"The team ({team.Name}) does not exist in this league ({Name})");
			}

			//Remove all matchups that the team is a part of
			foreach (var matchup in GetMatchups(team))
			{
				RemoveMatchup(matchup);
			}

			//For any item that belonged to the team, remove it from the team.  It will become a free agent
			foreach (var item in team.Roster)
			{
				item.RemoveFromTeam();
			}

			Teams.Remove(team);
		}

		/// <summary>
		/// Get all matchups in a given week
		/// </summary>
		/// <param name="week"></param>
		/// <returns></returns>
		public List<MatchupRegularSeason> GetMatchups(int week)
		{
			return MatchupsRegularSeason.Where(m => m.Week == week).ToList();
		}

		/// <summary>
		/// Get all matchups for a given team
		/// </summary>
		/// <param name="team">The team in question</param>
		/// <returns></returns>
		public List<MatchupRegularSeason> GetMatchups(Team team)
		{
			return MatchupsRegularSeason.Where(m => m.TeamIdA == team.Id || m.TeamIdB == team.Id).ToList();
		}

		/// <summary>
		/// Returns the team's single matchup from the given week
		/// </summary>
		/// <param name="team"></param>
		/// <param name="week"></param>
		/// <returns></returns>
		public MatchupRegularSeason GetMatchup(Team team, int week)
		{
			return MatchupsRegularSeason.Where(m => m.Week == week && (m.TeamIdA == team.Id || m.TeamIdB == team.Id)).Single();
		}

		public void RemoveMatchup(MatchupRegularSeason matchup)
		{
			if (!MatchupsRegularSeason.Contains(matchup))
			{
				throw new ArgumentException($"The matchup (id: {matchup.Id}) does not exist in this league ({Name})");
			}

			matchup.Delete();
			MatchupsRegularSeason.Remove(matchup);
		}

		/// <summary>
		/// Gets the current rank of a team in the league.  1-based
		/// </summary>
		/// <param name="team"></param>
		/// <returns></returns>
		public int GetRank(Team team)
		{
			//The use of this function will likely result in the ranked teams list being generated multiple times redudantly.
			//I don't care, teams lists will always be pretty small so it shouldn't matter

			return TeamsRanked.IndexOf(team) + 1;
		}

		/// <summary>
		/// Sort teams by head-to-head record. Teams that didn't play each other remain in original order.
		/// </summary>
		private IOrderedEnumerable<Team> SortByHeadToHead(List<Team> teams)
		{
			// Build head-to-head records between all teams in this group
			var headToHeadWins = teams.ToDictionary(t => t.Id, t => 0);

			foreach (var team in teams)
			{
				var matchupsAgainstTiedTeams = MatchupsRegularSeason
					.Where(m => m.Winner?.Id == team.Id &&
							   teams.Any(t => t.Id == m.Loser?.Id));

				headToHeadWins[team.Id] = matchupsAgainstTiedTeams.Count();
			}

			return teams.OrderByDescending(t => headToHeadWins[t.Id]);
		}


		public void GenerateRoundRobinSchedule()
		{
			//First, remove all existing matchups
			while (MatchupsRegularSeason.Count > 0)
			{
				RemoveMatchup(MatchupsRegularSeason.First());
			}

			var teams = Teams.ToList(); //Turn the teams into a list so we can iterate through them by index

			//Randomize the list of teams
			Random rng = new Random();
			for (int i = teams.Count - 1; i > 0; i--)
			{
				int j = rng.Next(i + 1);
				(teams[i], teams[j]) = (teams[j], teams[i]);
			}

			if (teams.Count % 2 == 1)
			{
				teams.Add(new Team("bye", this)); //add a bye team if there is an odd number
			}

			for (int week = 0; week < teams.Count - 1; week++)
			{
				//For each week, we'll matchup the teams in the list as follows (for an 8 team example):
				// 0 - 7
				// 1 - 6
				// 2 - 5
				// 3 - 4
				//Then we'll rotate indices 1-7 by 1, and rerun for the next week

				for (int i = 0; i < teams.Count / 2; i++)
				{
					//If one of the teams in this matchup is actually a bye, make the other team TeamA in the matchup
					//Set TeamB to null.  This signifies a bye
					if (teams[i].Name == "bye")
					{
						MatchupsRegularSeason.Add(new MatchupRegularSeason(week, teams[teams.Count - i - 1], null, this));
					}
					else if (teams[teams.Count - i - 1].Name == "bye")
					{
						MatchupsRegularSeason.Add(new MatchupRegularSeason(week, teams[i], null, this));
					}
					else
					{
						MatchupsRegularSeason.Add(new MatchupRegularSeason(week, teams[i], teams[teams.Count - i - 1], this));
					}
				}

				//Rotate the items in the list from index 1 onwards by 1, leaving 0 untouched
				var last = teams[teams.Count - 1];
				for (int i = teams.Count - 2; i >= 1; i--)
				{
					teams[i + 1] = teams[i];
				}
				teams[1] = last;
			}
		}
	}
}
