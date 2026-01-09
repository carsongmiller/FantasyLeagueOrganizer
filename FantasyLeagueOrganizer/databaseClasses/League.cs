using System;
using System.Collections.Generic;
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
			foreach (var category in item.ValidCategories)
			{
				category.RemoveItem(item);
			}

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
	}
}
