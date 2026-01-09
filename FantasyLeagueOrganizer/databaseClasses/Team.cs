using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FantasyLeagueOrganizer
{
	public class Team
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		/// <summary>
		/// A String containing the HTML color code (e.g. "#AABBCC")
		/// </summary>
		public string ColorCode { get; set; } = "#FFFFFF";

		public Color Color => ColorTranslator.FromHtml(ColorCode);

		public League League { get; set; }
		public Guid LeagueId { get; set; }

		public ICollection<Item> Roster => League.Items.Where(i => i.TeamId == Id).ToList();

		public ICollection<Item> Lineup => League.Items.Where(i => i.TeamId == Id && i.IsInLineup).ToList();

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
