using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer.Models
{
	public class Category
	{
		public string Name { get; set; }
		public Guid Id { get; set; }

		/// <summary>
		/// The items which belong to this category
		/// </summary>
		[NotMapped]
		public List<Item> Items => League.Items.Where(i => i.Categories.Contains(this)).ToList();

		public League League { get; set; }
		public Guid LeagueId { get; set; }

		/// <summary>
		/// Used whenever categories (or controls representing categories) are displayed in a list and need to be sorted
		/// </summary>
		public int SortIndex { get; set; } = int.MaxValue;

		public int RequiredCount { get; set; } = 0;

		[NotMapped]
		public List<Item> FreeAgents {
			get
			{ 
				var result = Items.Where(i => i.TeamId == null).ToList();
				return result;
			}
		}

		public Category() { }

		public Category(string name, int count, League league)
		{
			Id = Guid.NewGuid();
			Name = name;
			RequiredCount = count;
			League = league;
			LeagueId = league.Id;

			league.AddCategory(this);
		}

        public override string ToString()
        {
			return $"[Category] {Name}";
        }

		public bool SatisfiedByTeam(Team team)
		{
			return NumInLineup(team) == RequiredCount;
		}

		public int NumInLineup(Team team)
		{
			return team.Lineup.Where(i => i.AssignedCategoryId == Id).Count();
		}
	}
}
