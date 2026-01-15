using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	internal class MatchupResolver
	{
		public MatchupResult Resolve(Matchup matchup, Team teamA, Team teamB)
		{
			int scoreA = teamA.Lineup.Sum(i => matchup.RankingProvider.GetItemScore(i));
			int scoreB = teamB.Lineup.Sum(i => matchup.RankingProvider.GetItemScore(i));

			Team winner = scoreA > scoreB ? matchup.TeamA : matchup.TeamB;

			return new MatchupResult(winner, scoreA, scoreB);
		}
	}
}
