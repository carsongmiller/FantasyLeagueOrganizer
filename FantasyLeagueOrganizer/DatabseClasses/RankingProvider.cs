using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	/// <summary>
	/// A ranking provider that is simply a list of rankings for a set of items.  Completely static and pre-determined.
	/// </summary>
	public class RankingProvider
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string FlavorText1 { get; set; } = "Flavor Text 1";
		public string FlavorText2 { get; set; } = "Flavor Text 2";
		public string FlavorText3 { get; set; } = "Flavor Text 3";
		public string FlavorText4 { get; set; } = "Flavor Text 4";
		public League League { get; set; }
		public Guid LeagueId { get; set; }

		public IReadOnlyCollection<ItemRanking> Rankings => _rankings;
		private readonly List<ItemRanking> _rankings = new();

		[NotMapped]
		public bool SatisfiesLeague
		{
			get
			{
				var itemsRanked = Rankings.Select(r => r.Item.Id).ToHashSet();
				var leagueItems = League.Items.Select(i => i.Id).ToHashSet();
				return leagueItems.IsSubsetOf(itemsRanked);
			}
		}

		public RankingProvider() { }

		public RankingProvider(string name, IEnumerable<ItemRanking> rankings, League league)
		{
			Id = Guid.NewGuid();
			Name = name;
			League = league;
			LeagueId = league.Id;
			AddRankings(rankings);

			League.AddRankingProvider(this);
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
