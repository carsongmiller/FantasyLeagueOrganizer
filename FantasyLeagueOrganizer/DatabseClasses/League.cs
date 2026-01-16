using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
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
		public IReadOnlyCollection<Team> Teams => _teams;
		private readonly List<Team> _teams = new();

		/// <summary>
		/// All items in the league, including ones not assigned to teams
		/// </summary>
		public IReadOnlyCollection<Item> Items => _items;
		private readonly HashSet<Item> _items = new();

		/// <summary>
		/// List of all categories to which an item can belong
		/// </summary>
		public IReadOnlyCollection<Category> Categories => _categories;
		private readonly List<Category> _categories = new();

		public IReadOnlyCollection<Matchup> Matchups => _matchups;
		private readonly List<Matchup> _matchups = new();

		public IReadOnlyCollection<RankingProvider> RankingProviders => _rankingProviders;
		private readonly List<RankingProvider> _rankingProviders = new();

		[NotMapped]
		public List<Item> FreeAgents => _items.Where(i => i.TeamId == null).ToList();

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

		public void AddTeam(Team team)
		{
			_teams.Add(team);
		}

		public void AddItem(Item item)
		{
			_items.Add(item);
		}

		public void AddCategory(Category category)
		{
			_categories.Add(category);
		}

		public void AddMatchup(Matchup matchup)
		{
			_matchups.Add(matchup);
		}

		public void AddRankingProvider(RankingProvider provider)
		{
			_rankingProviders.Add(provider);
		}

		public bool ContainsTeam(string name)
		{
			return _teams.Any(t => t.Name == name);
		}

		public bool ContainsTeam(Guid id)
		{
			return _teams.Any(t => t.Id == Id);
		}

		public Team? GetTeam(string name)
		{
			return _teams.FirstOrDefault(t => t.Name == name);
		}

		public bool ContainsItemWithName(string name)
		{
			return _items.Any(i => i.Name == name);
		}

		public bool ContainsItem(Guid id)
		{
			return _items.Any(i => i.Id == id);
		}

		public Item? GetItem(string name)
		{
			return _items.FirstOrDefault(i => i.Name == name);
		}

		public void RemoveItem(Item item)
		{
			if (!_items.Contains(item))
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
			_items.Remove(item);
		}

		public void RemoveCategory(Category category)
		{
			if (!_categories.Contains(category))
			{
				throw new ArgumentException($"The category ({category.Name}) does not exist in this league ({Name})");
			}

			//remove the category from the validCategories list of all items that belong to it
			foreach (var item in category.Items)
			{
				item.RemoveCategory(category);
			}

			_categories.Remove(category);
		}

		public void RemoveTeam(Team team)
		{
			if (!_teams.Contains(team))
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

			_teams.Remove(team);
		}

		/// <summary>
		/// Get all matchups in a given week
		/// </summary>
		/// <param name="week"></param>
		/// <returns></returns>
		public List<Matchup> GetMatchups(int week)
		{
			return _matchups.Where(m => m.Week == week).ToList();
		}

		/// <summary>
		/// Get all matchups for a given team
		/// </summary>
		/// <param name="team">The team in question</param>
		/// <returns></returns>
		public List<Matchup> GetMatchups(Team team)
		{
			return _matchups.Where(m => m.TeamIdA == team.Id || m.TeamIdB == team.Id).ToList();
		}

		/// <summary>
		/// Returns the team's single matchup from the given week
		/// </summary>
		/// <param name="team"></param>
		/// <param name="week"></param>
		/// <returns></returns>
		public Matchup GetMatchup(Team team, int week)
		{
			return _matchups.Where(m => m.Week == week && (m.TeamIdA == team.Id || m.TeamIdB == team.Id)).Single();
		}

		public void RemoveMatchup(Matchup matchup)
		{
			if (!_matchups.Contains(matchup))
			{
				throw new ArgumentException($"The matchup (id: {matchup.Id}) does not exist in this league ({Name})");
			}

			matchup.Delete();
			_matchups.Remove(matchup);
		}

		public void GenerateRoundRobinSchedule()
		{
			//First, remove all existing matchups
			while (Matchups.Count > 0)
			{
				RemoveMatchup(Matchups.First());
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
						AddMatchup(new Matchup(week, teams[teams.Count - i - 1], null, this));
					}
					else if (teams[teams.Count - i - 1].Name == "bye")
					{
						AddMatchup(new Matchup(week, teams[i], null, this));
					}
					else
					{
						AddMatchup(new Matchup(week, teams[i], teams[teams.Count - i - 1], this));
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
