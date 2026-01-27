using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace FantasyLeagueOrganizer.Models
{
    public static class PlayoffGenerator
    {
        public enum PlayoffStyle
        {
            SingleElim,
            DoubleElim
        }

        public static List<MatchupPlayoffs> GeneratePlayoffs(League league, int numTeams, PlayoffStyle style)
        {
			if (style == PlayoffStyle.SingleElim)
			{
				return GenerateSingleEliminationBracket(league, numTeams);
			}
			else if (style == PlayoffStyle.DoubleElim)
			{
				return GenerateDoubleEliminationBracket(league, numTeams);
			}
			else
			{
				//the style is something we don't support yet
				return new List<MatchupPlayoffs>();
			}
        }

		private static List<MatchupPlayoffs> GenerateSingleEliminationBracket(League league, int numTeams)
		{
			if (league.Teams.Count < 2)
			{
				throw new ArgumentException($"League must contain two or more {league.DisplayNameTeamPlural} to generate a playoff bracket");
			}

			var matchups = new List<MatchupPlayoffs>();
			//generate the number of first round teams we'll have, rounded up to the nearest power of two

			int numFirstRoundSlots = 1;

			while (numFirstRoundSlots < numTeams)
			{
				numFirstRoundSlots *= 2;
			}

			var seedList = GenerateBracketSeedingOrder(numFirstRoundSlots);
			int seedIndex = 0;

			//Generate all of the matchups for the bracket (not yet accounting for byes)
			int round = 1;
			var numMatchupsThisRound = numFirstRoundSlots / round / 2;

			var teamsRankedList = league.TeamsRanked.Take(numTeams).ToList();

			while (numMatchupsThisRound >= 1)
			{
				var matchupsThisRound = new List<MatchupPlayoffs>();
				var matchupsWithoutChildren = matchups.Where(m => m.Child is null).ToList();

				for (int matchIndexThisRound = 0; matchIndexThisRound < numMatchupsThisRound; matchIndexThisRound++)
				{
					MatchupPlayoffs newMatchup = new(league);
					var teamsThisRound = numMatchupsThisRound * 2;

					if (round > 1)
					{
						newMatchup.ParentA = matchupsWithoutChildren.First();
						newMatchup.ParentA.Child = newMatchup;
						matchupsWithoutChildren.Remove(newMatchup.ParentA);

						newMatchup.ParentB = matchupsWithoutChildren.First();
						newMatchup.ParentB.Child = newMatchup;
						matchupsWithoutChildren.Remove(newMatchup.ParentB);
					}
					else
					{
						//newMatchup.TeamA = teamsRankedList[seedList[seedIndex]];
						newMatchup.SeedA = seedList[seedIndex++];

						//newMatchup.TeamB = teamsRankedList[seedList[seedIndex]];
						newMatchup.SeedB = seedList[seedIndex++];
					}

					matchupsThisRound.Add(newMatchup);
				}

				matchups.AddRange(matchupsThisRound);

				round++;
				numMatchupsThisRound = numFirstRoundSlots / (int)Math.Pow(2, round);
			}

			//remove all matchups which should be a bye, and advance the other team in that matchup to the next round automatically
			//We should never have a scenario where BOTH seeds in a matchup need to be removed
			for (int i = 0; i < matchups.Count; i++) 
			{
				var matchup = matchups[i];

				if (matchup.SeedA == 0 || matchup.SeedB  == 0) continue; //The only matchups we care about will have BOTH seeds assigned

				if (matchup.SeedA > teamsRankedList.Count)
				{
					//This matchup's teamA should be a bye.  Push teamB to the child
					if (matchup.Child.ParentA == matchup)
					{
						//We are our child's A parent, so fill the child's A slot with our teamB info
						matchup.Child.SeedA = matchup.SeedB;
						matchup.Child.TeamA = matchup.TeamB;
						matchup.Child.TeamIdA = matchup.TeamIdB;
						matchup.Child.ParentAId = null;
						matchup.Child.ParentA = null;
					}
					else if (matchup.Child.ParentB == matchup)
					{
						//We are our child's B parent, so fill the child's B slot with our teamB info
						matchup.Child.SeedB = matchup.SeedB;
						matchup.Child.TeamB = matchup.TeamB;
						matchup.Child.TeamIdB = matchup.TeamIdB;
						matchup.Child.ParentBId = null;
						matchup.Child.ParentB = null;
					}

					matchups.RemoveAt(i--);
				}
				else if (matchup.SeedB > teamsRankedList.Count)
				{
					//This matchup's teamB should be a bye.  Push teamA to the child
					if (matchup.Child.ParentA == matchup)
					{
						//We are our child's A parent, so fill the child's A slot with our teamA info
						matchup.Child.SeedA = matchup.SeedA;
						matchup.Child.TeamA = matchup.TeamA;
						matchup.Child.TeamIdA = matchup.TeamIdA;
						matchup.Child.ParentAId = null;
						matchup.Child.ParentA = null;
					}
					else if (matchup.Child.ParentB == matchup)
					{
						//We are our child's B parent, so fill the child's B slot with our teamA info
						matchup.Child.SeedB = matchup.SeedA;
						matchup.Child.TeamB = matchup.TeamA;
						matchup.Child.TeamIdB = matchup.TeamIdA;
						matchup.Child.ParentBId = null;
						matchup.Child.ParentB = null;
					}

					matchups.RemoveAt(i--);
				}
			}

			//Assign all teams to their correct positions
			foreach (var matchup in matchups)
			{
				if (matchup.SeedA != 0)
				{
					matchup.TeamA = teamsRankedList[matchup.SeedA - 1];
				}

				if (matchup.SeedB != 0)
				{
					matchup.TeamB = teamsRankedList[matchup.SeedB - 1];
				}
			}

			//Print for debug
			foreach (var matchup in matchups)
			{
				Debug.WriteLine(matchup.PrintDebug() + "\r\n");
			}

			return matchups;
		}

		private static List<MatchupPlayoffs> GenerateDoubleEliminationBracket(League league, int numTeams)
		{
			var matchups = new List<MatchupPlayoffs>();
			
			


			return matchups;
		}

		/// <summary>
		/// Generates the seeding order for a single-elimination bracket.
		/// Returns seeds in the order they appear from top to bottom in the bracket.
		/// Example for 8 teams: [1, 8, 4, 5, 2, 7, 3, 6]
		/// This creates matchups: 1v8, 4v5, 2v7, 3v6
		/// </summary>
		private static List<int> GenerateBracketSeedingOrder(int numTeams)
		{
			// Find next power of 2
			int bracketSize = 1;
			while (bracketSize < numTeams)
			{
				bracketSize *= 2;
			}

			// Start with seeds 1 and 2
			var seeds = new List<int> { 1, 2 };

			// Build up the bracket by inserting complements
			// Each round, we insert the "opponent" seed between existing seeds
			int currentRoundSize = 2;

			while (currentRoundSize < bracketSize)
			{
				var newSeeds = new List<int>();

				foreach (var seed in seeds)
				{
					newSeeds.Add(seed);
					// The complement is: (currentRoundSize * 2) + 1 - seed
					int complement = (currentRoundSize * 2) + 1 - seed;
					newSeeds.Add(complement);
				}

				seeds = newSeeds;
				currentRoundSize *= 2;
			}

			// If we have byes, replace bye seeds (> numTeams) with -1 or keep them
			// Keep them as-is for now - you can filter later if needed

			return seeds;
		}
	}
}
