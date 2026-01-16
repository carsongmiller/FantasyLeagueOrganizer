using FantasyLeagueOrganizer.controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyLeagueOrganizer.DatabseClasses
{
    public static class DatabaseHelpers
    {
        public static League? LoadLeague()
        {
			League? league = null;
			try
			{
				using var context = new LeagueDbContext();

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

		//public static void SaveChanges(League league)
		//{
		//	try
		//	{
		//		using var context = new LeagueDbContext();
		//		context.Leagues.Attach(league);
		//		context.Leagues.Update(league);
		//		context.SaveChanges();
		//	}
		//	catch (DbUpdateException ex)
		//	{
		//		var root = ex.GetBaseException()?.Message ?? ex.Message;
		//		MessageBox.Show($"Save failed: {root}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//}

		public static void Update(object entity)
		{
			try
			{
				using var context = new LeagueDbContext();
				context.Attach(entity);
				context.Entry(entity).State = EntityState.Modified;
				context.SaveChanges();
			}
			catch (DbUpdateException ex)
			{
				var root = ex.GetBaseException()?.Message ?? ex.Message;
				MessageBox.Show($"Save failed: {root}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
