using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FantasyLeagueOrganizer.Models
{
    internal class MatchupPlayoffs
    {
		public Guid Id { get; set; }

		// Actual teams (populated when known)
		public Team? TeamA { get; set; }
		public Guid? TeamIdA { get; set; }
		public Team? TeamB { get; set; }
		public Guid? TeamIdB { get; set; }

		// For FIRST round only - seeding from regular season
		/// <summary>
		/// FIRST ROUND ONLY.  Seed that will fill this slot (1 based)
		/// </summary>
		public int? SeedA { get; set; }  // e.g., 1, 2, 3, 4

		/// <summary>
		/// FIRST ROUND ONLY.  Seed that will fill this slot (1 based)
		/// </summary>
		public int? SeedB { get; set; }


		// For LATER rounds - references to previous matchups
		public MatchupPlayoffs? SourceMatchupA { get; set; }
		public Guid? SourceMatchupIdA { get; set; }

		/// <summary>
		/// True if the WINNER of the source matchup fills this slot, false if the loser does
		/// </summary>
		public bool SourceAIsWinner { get; set; } // true = winner, false = loser (for double elim)


		public MatchupPlayoffs? SourceMatchupB { get; set; }
		public Guid? SourceMatchupIdB { get; set; }
		/// <summary>
		/// True if the WINNER of the source matchup fills this slot, false if the loser does
		/// </summary>
		public bool SourceBIsWinner { get; set; }


		public int ScoreA { get; set; }
		public int ScoreB { get; set; }
		public Team? Winner { get; set; }
		public bool IsComplete { get; set; }

		public RankingProvider? RankingProvider { get; set; }
		public Guid? RankingProviderId { get; set; }
	}
}
