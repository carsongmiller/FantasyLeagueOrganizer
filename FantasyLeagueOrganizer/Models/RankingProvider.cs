using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer.Models
{
	/// <summary>
	/// A ranking provider that is simply a list of rankings for a set of items.  Completely static and pre-determined.
	/// </summary>
	/// <remarks>Ranking providers do not belong to or contain a reference to any single league</remarks>
	public class RankingProvider
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string FlavorText1 { get; set; } = "Flavor Text 1";
		public string FlavorText2 { get; set; } = "Flavor Text 2";
		public string FlavorText3 { get; set; } = "Flavor Text 3";
		public string FlavorText4 { get; set; } = "Flavor Text 4";
		//public League League { get; set; }
		//public Guid LeagueId { get; set; }

		public IReadOnlyCollection<ItemRanking> Rankings => _rankings;
		private readonly List<ItemRanking> _rankings = new();

		public bool SatisfiesLeague(League league)
		{
				var itemsRanked = Rankings.Select(r => r.Item.Id).ToHashSet();
				var leagueItems = league.Items.Select(i => i.Id).ToHashSet();
				return leagueItems.IsSubsetOf(itemsRanked);
		}

		public RankingProvider() { }

		public RankingProvider(string name, IEnumerable<ItemRanking> rankings)
		{
			Id = Guid.NewGuid();
			Name = name;
			AddRankings(rankings);
		}

        public override string ToString()
        {
            return $"[Ranking Provider] {Name}";
		}

		public int GetItemScore(Item item)
		{
			var ranking = Rankings.Where(r => r.Item.Id == item.Id).Single();
			return ranking.Score;
		}

		public void AddRanking(ItemRanking ranking)
		{
			if (ranking == null)
			{
				throw new ArgumentNullException(nameof(ranking));
			}

			if (ranking.RankingProvider != null && ranking.RankingProvider.Id != Id)
			{
				throw new ArgumentException($"The provided ranking (for item {ranking.Item.Name}) is already associated with a different ranking provider ({ranking.RankingProvider.Name})");
			}

			ranking.RankingProvider = this;
			ranking.RankingProviderId = Id;
			_rankings.Add(ranking);
		}

		public void AddRankings(IEnumerable<ItemRanking> rankings)
		{
			foreach (var ranking in rankings)
			{
				AddRanking(ranking);
			}
		}
	}
}
