using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	public class Matchup
	{
		public Guid Id { get; set; }
		public Team TeamA { get; }
		public Team TeamB { get; }
		public IRankingProvider RankingProvider { get; }

		public Matchup ()
		{

		}

		public Matchup(Team teamA, Team teamB, IRankingProvider rankingProvider)
		{
			TeamA = teamA;
			TeamB = teamB;
			RankingProvider = rankingProvider;
		}
	}
}
