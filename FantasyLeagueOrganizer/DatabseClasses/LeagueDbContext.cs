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
		public DbSet<RankingProvider> RankingProviders => Set<RankingProvider>();
		public DbSet<Matchup> Matchups => Set<Matchup>();

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite("Data Source=.\\..\\..\\..\\database\\league.db");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Item>()
				.HasMany(i => i.Categories)
				.WithMany(c => c.Items);

			modelBuilder.Entity<Team>()
				.HasOne(t => t.League)
				.WithMany(l => l.Teams)
				.HasForeignKey(t => t.LeagueId)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Item>()
				.HasOne(i => i.Team)
				.WithMany()
				.HasForeignKey(i => i.TeamId)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<League>()
				.HasMany(l => l.Teams)
				.WithOne(t => t.League);

			base.OnModelCreating(modelBuilder);
		}
	}
}
