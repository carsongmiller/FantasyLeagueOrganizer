using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FantasyLeagueOrganizer
{
	public class LeagueDbContext: DbContext
	{
		public DbSet<League> Leagues => Set<League>();
		public DbSet<Team> Teams => Set<Team>();
		public DbSet<Item> Items => Set<Item>();
		public DbSet<Category> Categories => Set<Category>();
		public DbSet<StaticRankingProvider> RankingProviders => Set<StaticRankingProvider>();
		public DbSet<Matchup> Matchups => Set<Matchup>();

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite("Data Source=.\\..\\..\\..\\database\\league.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Team>()
				.Ignore(t => t.Roster)
				.Ignore(t => t.Lineup)
				.Ignore(t => t.Color);

			base.OnModelCreating(modelBuilder);
		}
	}
}
