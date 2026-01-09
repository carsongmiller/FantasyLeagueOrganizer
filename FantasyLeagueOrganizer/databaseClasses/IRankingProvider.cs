using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyLeagueOrganizer
{
	public interface IRankingProvider
	{
		string Name { get; }
		int GetScore(Item item);
	}
}
