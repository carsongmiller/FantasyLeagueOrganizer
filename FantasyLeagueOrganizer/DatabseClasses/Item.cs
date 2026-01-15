using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	public class Item
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		/// <summary>
		/// The categories to which this item belongs
		/// </summary>
		public IReadOnlyCollection<Category> Categories => _categories;
		private readonly HashSet<Category> _categories = new();

		public Team? Team { get; set; }
		public Guid? TeamId { get; set; }

		public League League {  get; set; }
		public Guid LeagueId { get; set; }

		public bool IsInLineup { get; private set; }

		[NotMapped]
		public bool IsFreeAgent => TeamId == null;

		/// <summary>
		/// The Guid of the roster rule to which this item contributes, or null if it is not assigned to any roster slot
		/// </summary>
		public Guid? AssignedCategoryId { get; private set; }

		public Item() { }

		public Item(string name, Category category, League league) : this(name, new List<Category>() { category }, league) { }

		public Item(string name, IEnumerable<Category> categories, League league)
		{
			Name = name;
			Id = Guid.NewGuid();

			AddCategories(categories);

			League = league;
			LeagueId = league.Id;

			league.AddItem(this);
		}

		public string AssignedCategoryName => AssignedCategoryId == null ? "Unassigned" : Categories.Single(c => c.Id == AssignedCategoryId).Name;

		public override string ToString()
		{
			return $"[Item] {Name}";
		}

		public void AddToTeam(Team team)
		{
			if (team.LeagueId != LeagueId)
			{
				throw new InvalidOperationException("Item and Team are not in the same league");
			}

			Team = team;
			TeamId = team.Id;
			AssignedCategoryId = null;
			IsInLineup = false;
		}

		public void RemoveFromTeam()
		{
			Team = null;
			TeamId = null;
			AssignedCategoryId = null;
			IsInLineup = false;
		}

		/// <summary>
		/// Add this item to the lineup
		/// </summary>
		/// <param name="categoryId">The Id of the category for which you'd like this item to count</param>
		/// <exception cref="InvalidOperationException"></exception>
		public void AddToLineup(Guid categoryId)
		{
            if (TeamId == null)
			{
				throw new InvalidOperationException("Item is not on a team");
			}

			if (!Categories.Any(c => c.Id == categoryId))
			{
				throw new InvalidOperationException("Item does not belong to the specified category");
			}

			AssignedCategoryId = categoryId;

			IsInLineup = true;
		}

		/// <summary>
		/// Add this item to the lineup
		/// </summary>
		/// <param name="categoryId">The category for which you'd like this item to count</param>
		/// <exception cref="InvalidOperationException"></exception>
		public void AddToLineup(Category category)
		{
			AddToLineup(category.Id);
		}

		public void RemoveFromLineup()
		{
			IsInLineup = false;
			AssignedCategoryId = null;
		}

		public void AddCategories(IEnumerable<Category> categories)
		{
			_categories.UnionWith(categories);
			//foreach (var category in categories)
			//{
			//	category.AddItem(this);
			//}
		}

		public void AddCategory(Category category)
		{
			_categories.Add(category);
		}

		public void RemoveCategory(Category category)
		{
			if (!_categories.Contains(category))
			{
				throw new ArgumentException($"The category ({category.Name}) is not in this item's ({Name}) validCategories list");
			}

			_categories.Remove(category);

			if (AssignedCategoryId == category.Id)
			{
				RemoveFromLineup();
			}
		}

		public void SetCategories(IEnumerable<Category> categories)
		{
			_categories.Clear();
			_categories.UnionWith(categories);
		}

		public bool BelongsToCategory(Category category)
		{
			return _categories.Any(c => c.Id == category.Id);
		}

		public bool BelongsToCategory(Guid id)
		{
			return _categories.Any(c => c.Id == id);
		}
	}
}
