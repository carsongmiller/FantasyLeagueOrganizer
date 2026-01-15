using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	internal class MatchupResult
	{
		public Team Winner { get; }
		public int ScoreA { get; }
		public int ScoreB { get; }

		public bool WasATie { get => ScoreA == ScoreB; }

		public MatchupResult()
		{

		}

		public MatchupResult(Team winner, int scoreA, int scoreB)
		{
			Winner = winner;
			ScoreA = scoreA;
			ScoreB = scoreB;
		}
	}
}
