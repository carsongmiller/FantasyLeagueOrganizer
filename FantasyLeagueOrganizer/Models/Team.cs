using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FantasyLeagueOrganizer.Models
{
	public class Team
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		/// <summary>
		/// A String containing the HTML color code (e.g. "#AABBCC")
		/// </summary>
		public string ColorCode { get; set; } = "#FFFFFF";

		[NotMapped]
		public Color Color {
			get => ColorTranslator.FromHtml(ColorCode);
			set => ColorCode = $"#{value.R:X2}{value.G:X2}{value.B:X2}";
		}

		public League League { get; set; }
		public Guid LeagueId { get; set; }

		public string Password { get; set; } = "password";

		/// <summary>
		/// First position = 0
		/// </summary>
		public int DraftPosition { get; set; } = int.MaxValue;

		public ICollection<Item> Roster => League.Items.Where(i => i.TeamId == Id).ToList();

		[NotMapped]
		public ICollection<Item> Lineup => League.Items.Where(i => i.TeamId == Id && i.IsInLineup).ToList();

		[NotMapped]
		public int Wins => League.GetMatchups(this).Where(m => m.Winner == this).Count();

		[NotMapped]
		public int Losses => League.GetMatchups(this).Where(m => m.Loser == this).Count();

		[NotMapped]
		public int Ties => League.GetMatchups(this).Where(m => m.Result == MatchupResult.Tie).Count();

		public bool LineupIsValid 
		{
			get
			{
				foreach (var category in League.Categories)
				{
					if (!category.SatisfiedByTeam(this)) return false;
				}
				return true;
			}
		}

		/// <summary>
		/// The team's record, in the form of "W - L - T"
		/// </summary>
		[NotMapped]
		public string RecordString => $"{Wins} - {Losses} - {Ties}";

		public Team() { }

		public Team(string name, League league)
		{
			Id = Guid.NewGuid();
			Name = name;

			League = league;
			LeagueId = league.Id;

			league.AddTeam(this);
		}

		public override string ToString()
		{
			return $"[Team] {Name}";
		}

		public void CopyFrom(Team team)
		{
			Color = team.Color;
			DraftPosition = team.DraftPosition;
			Name = team.Name;
		}

		public void SetColor(string color)
		{
			ColorCode = color;
		}

		public bool ValidateLineup()
		{
            foreach (var category in League.Categories)
			{
				if (Lineup.Where(i => i.AssignedCategoryId == category.Id).Count() != category.RequiredCount)
				{
					return false;
				}
			}
			return true;
		}

	}
}
