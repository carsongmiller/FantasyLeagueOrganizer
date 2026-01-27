using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FantasyLeagueOrganizer.Models
{
    public class MatchupPlayoffs
    {
		public Guid Id { get; set; }

		public League League { get; set; }
		public Guid LeagueId { get; set; }


		// Actual teams (populated when known)
		public Team? TeamA { get; set; }
		public Guid? TeamIdA { get; set; }
		public Team? TeamB { get; set; }
		public Guid? TeamIdB { get; set; }

		/// <summary>
		/// FIRST ROUND ONLY.  Seed that will fill this slot (1 based) (0 means it hasn't been assigned)
		/// </summary>
		public int SeedA { get; set; } = 0;

		/// <summary>
		/// FIRST ROUND ONLY.  Seed that will fill this slot (1 based) (0 means it hasn't been assigned)
		/// </summary>
		public int SeedB { get; set; } = 0;

		/// <summary>
		/// The result of this matchup
		/// </summary>
		public MatchupResult Result { get; set; } = MatchupResult.Incomplete;


		/// <summary>
		/// If null, then this is a first round matchup or the null position represents a bye
		/// </summary>
		public MatchupPlayoffs? ParentA { get; set; }
		public Guid? ParentAId { get; set; }

		/// <summary>
		/// True if the WINNER of the source matchup fills this slot, false if the loser does
		/// </summary>
		public bool ParentAIsWinner { get; set; } // true = winner, false = loser (for double elim)

		/// <summary>
		/// If null, then this is a first round matchup or the null position represents a bye
		/// </summary>
		public MatchupPlayoffs? ParentB { get; set; }
		public Guid? ParentBId { get; set; }
		/// <summary>
		/// True if the WINNER of the source matchup fills this slot, false if the loser does
		/// </summary>
		public bool ParentBIsWinner { get; set; }

		/// <summary>
		/// The child of this matchup.  If null, then this is the championship
		/// </summary>
		public MatchupPlayoffs? Child { get; set; }

		/// <summary>
		/// Team A's Score
		/// </summary>
		public int ScoreA { get; set; }

		/// <summary>
		/// Team B's Score
		/// </summary>
		public int ScoreB { get; set; }

		public RankingProvider? RankingProvider { get; set; }
		public Guid? RankingProviderId { get; set; }

		public MatchupPlayoffs(League league)
		{
			Id = Guid.NewGuid();
			League = league;
			LeagueId = league.Id;
			League.MatchupsPlayoffs.Add(this);
		}

        public override string ToString()
        {
			return $"[Playoff] {TeamA?.Name ?? "N/A"} vs. {TeamB?.Name ?? "N/A"} ({SeedA} vs. {SeedB})";
        }

		public string PrintDebug()
		{
			var str = $"Team A: {TeamA?.Name ?? "null"}\r\n";
			str += $"Team B: {TeamB?.Name ?? "null"}\r\n";
			str += $"Parent A: {ParentA?.Id.ToString() ?? "null"}\r\n";
			str += $"Parent B: {ParentB?.Id.ToString() ?? "null"}\r\n";
			str += $"Child: {Child?.Id.ToString() ?? "null"}";

			return str;
		}
	}
}
