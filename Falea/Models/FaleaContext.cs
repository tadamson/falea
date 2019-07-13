using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Falea.Models
{
    public class FaleaContext : DbContext
    {
        public FaleaContext(DbContextOptions<FaleaContext> options)
            : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // composite pk for match players
            modelBuilder.Entity<MatchPlayer>()
                .HasKey(t => new { t.MatchId, t.PlayerId });

            // many:many on league<->tournament
            modelBuilder.Entity<LeagueTournament>().HasKey(t => new { t.LeagueId, t.TournamentId });
            modelBuilder.Entity<LeagueTournament>()
                .HasOne(lt => lt.League)
                .WithMany(t => t.LeagueTournaments)
                .HasForeignKey(lt => lt.LeagueId);
            modelBuilder.Entity<LeagueTournament>()
                .HasOne(lt => lt.Tournament)
                .WithMany(t => t.LeagueTournaments)
                .HasForeignKey(lt => lt.TournamentId);

        }
    }
}
