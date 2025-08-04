using Entity.Domain.Models.Implements;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Metadata;

namespace Entity.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Move>()
            .HasOne(m => m.Round)
            .WithMany(r => r.Moves)
            .HasForeignKey(m => m.RoundId)
            .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Player> Players { get; set; }
        public  DbSet<Card> Cards { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GamePlayer> GamePlayers { get; set; }
        public DbSet<Deck> Deck { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Move> Moves { get; set; }




    }
}
