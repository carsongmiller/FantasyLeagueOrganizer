using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	internal class ItemRanking
	{
		public Guid RankingProviderId { get; }
		public Guid LeagueItemId { get; }
		public int Score { get; }
	}
}
