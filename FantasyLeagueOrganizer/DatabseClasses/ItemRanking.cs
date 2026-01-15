using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	public class ItemRanking
	{
		public Guid Id { get; set; }
		public RankingProvider RankingProvider { get; set; }
		public Guid RankingProviderId { get; set; }

		public Item Item { get; set; }
		public Guid ItemId { get; set; }
		public int Score { get; set; } = 0;

		public ItemRanking() { }

		public ItemRanking(Item item, int score)
		{
			Id = Guid.NewGuid();
			Item = item;
			Score = score;
		}

        public override string ToString()
        {
			return $"{Item.Name} - {Score}";
        }
	}
}
