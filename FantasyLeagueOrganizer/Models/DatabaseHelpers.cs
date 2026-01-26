using FantasyLeagueOrganizer.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyLeagueOrganizer.Models
{
    public static class DatabaseHelpers
    {
		public static League? LoadLeague(LeagueDbContext context)
		{
			League? league = null;
			try
			{
				league = context.Leagues
					.AsSplitQuery()
					.Include(l => l.Teams)
					.Include(l => l.Items)
						.ThenInclude(i => i.Categories)
					.Include(l => l.Categories)
					.Include(l => l.RankingProviders)
						.ThenInclude(r => r.Rankings)
							.ThenInclude(r => r.Item)
					.Include(l => l.Matchups)
					.Single();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load league\r\n\r\n" + ex.Message);
			}

			return league;
		}
	}
}
