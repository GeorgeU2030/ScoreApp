using backend.Models;
using Microsoft.EntityFrameworkCore;

public class ScoreAppContext : DbContext
{
    public ScoreAppContext(DbContextOptions<ScoreAppContext> options)
        : base(options)
    {
    }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Season> Seasons { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tournament>()
            .HasMany(e => e.Seasons)
            .WithOne(e => e.Tournament)
            .HasForeignKey(e => e.TournamentId)
            .IsRequired();
    }
}
