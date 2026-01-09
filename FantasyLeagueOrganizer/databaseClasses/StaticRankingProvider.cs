using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	/// <summary>
	/// A ranking provider that is simply a list of rankings for a set of items.  Completely static and pre-determined.
	/// </summary>
	public class StaticRankingProvider : IRankingProvider
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		private readonly Dictionary<Guid, int> Scores;

		public StaticRankingProvider() { }

		public StaticRankingProvider(string name, Dictionary<Guid, int> scores)
		{
			Name = name;
			Scores = scores;
		}

		public int GetScore(Item item)
		{
			return Scores[item.Id];
		}
	}
}
