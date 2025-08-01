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
            //modelBuilder.Entity<Blog>()
            //    .HasOne(e => e.Header)
            //    .WithOne(e => e.Blog)
            //    .HasForeignKey<BlogHeader>(e => e.BlogId)
            //    .IsRequired();


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Player> Players { get; set; }
        public  DbSet<Card> Cards { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<GamePlayer> GamePlayers { get; set; }
        public DbSet<Deck> Deck { get; set; }




    }
}
