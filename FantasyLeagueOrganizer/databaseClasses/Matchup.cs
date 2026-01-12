using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FantasyLeagueOrganizer
{
	public class Matchup
	{
		public Guid Id { get; set; }
		public Team TeamA { get; set; }
		public Guid TeamIdA { get; set; }
		public Team? TeamB { get; set; }
		public Guid? TeamIdB { get; set; }

		/// <summary>
		/// The week of the season during which this matchup will occur
		/// </summary>
		public int Week { get; set; }

		public MatchupResult Result { get; set; } = MatchupResult.NotYetPlayed;

		public Team Winner
		{
			get
			{
				if (Result == MatchupResult.AWon) return TeamA;
				else if (Result == MatchupResult.BWon) return TeamB;
				else return null;
			}
		}

		public Team Loser
		{
			get
			{
				if (Result == MatchupResult.AWon) return TeamB;
				else if (Result == MatchupResult.BWon) return TeamA;
				else return null;
			}
		}

		public enum MatchupResult
		{
			AWon,
			BWon,
			Tie,
			NotYetPlayed
		}

		public RankingProvider RankingProvider { get; set; }

		/// <summary>
		/// Whether this matchup represents a bye week for TeamA
		/// </summary>
		[NotMapped]
		public bool IsBye => TeamB == null;

		public Matchup ()
		{

		}

		public Matchup(int week, Team teamA, Team? teamB)
		{
			Week = week;

			if (teamA == null && teamB == null)
			{
				throw new ArgumentNullException("Both teams cannot be null. One null team signifies it is a bye week for the other team");
			}
			else if (teamA == null)
			{
				TeamA = teamB;
				TeamIdA = teamB.Id;

				TeamB = null;
				TeamIdB = null;
			}
			else if (teamB == null)
			{
				TeamA = teamA;
				TeamIdA = teamA.Id;

				TeamB = null;
				TeamIdB = null;
			}
			else
			{
				TeamA = teamA;
				TeamIdA = teamA.Id;
				TeamB = teamB;
				TeamIdB = teamB.Id;
			}
		}

		public override string ToString()
		{
			var teamBText = TeamB != null ? TeamB.Name : "BYE";
			return $"[Week {Week}] {TeamA.Name} vs. {teamBText}";
		}
	}
}
