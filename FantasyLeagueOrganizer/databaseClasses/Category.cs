using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	public class Category
	{
		public string Name { get; set; }
		public Guid Id { get; set; }

		/// <summary>
		/// The items which belong to this category
		/// </summary>
		public IReadOnlyCollection<Item> Items => _items;
		private readonly HashSet<Item> _items = new();

		public League League { get; set; }
		public Guid LeagueId { get; set; }

		public int RequiredCount { get; set; } = 0;

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

		public void AddItem(Item item)
		{
			_items.Add(item);
		}

		public void RemoveItem(Item item)
		{
			if (!_items.Contains(item))
			{
				throw new ArgumentException($"The item ({item.Name}) does not exist in this category ({Name})");
			}

			_items.Remove(item);
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
