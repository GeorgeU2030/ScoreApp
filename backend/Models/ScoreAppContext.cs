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
    public DbSet<Team> Teams { get; set; }
    public DbSet<Trophy> Trophies { get; set; }
    public DbSet<TeamSoccer> TeamsSoccer { get; set; }
    public DbSet<TeamSport> TeamsSport { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerSeason> PlayersSeason { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<MatchSport> MatchesSport { get; set; }
    public DbSet<MatchPlayer> MatchesPlayer { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Winrace> Winraces { get; set; }
    public DbSet<DriverSeason> DriversSeason { get; set; }
    public DbSet<Race> Races { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tournament>()
            .HasMany(e => e.Seasons)
            .WithOne(e => e.Tournament)
            .HasForeignKey(e => e.TournamentId)
            .IsRequired();

        modelBuilder.Entity<Team>()
            .HasMany(e => e.Trophies)
            .WithOne(e => e.Team)
            .HasForeignKey(e => e.TeamId)
            .IsRequired();

        modelBuilder.Entity<Season>()
            .HasMany(e => e.TeamsSoccer)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();
        
        modelBuilder.Entity<Season>()
            .HasMany(e => e.TeamsSport)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();

        modelBuilder.Entity<Season>()
            .HasMany(e => e.PlayersSeason)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();

        modelBuilder.Entity<Season>()
            .HasMany(e => e.Matches)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();
        
        modelBuilder.Entity<Season>()
            .HasMany(e => e.MatchesSport)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();

        modelBuilder.Entity<Season>()
            .HasMany(e => e.MatchesPlayer)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();
        
        modelBuilder.Entity<Driver>()
            .HasMany(e => e.Winraces)
            .WithOne(e => e.Driver)
            .HasForeignKey(e => e.DriverId)
            .IsRequired();
        
        modelBuilder.Entity<Season>()
            .HasMany(e => e.DriversSeason)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();

         modelBuilder.Entity<Season>()
            .HasMany(e => e.Races)
            .WithOne(e => e.Season)
            .HasForeignKey(e => e.SeasonId)
            .IsRequired();
        
        modelBuilder.Entity<Race>()
            .HasOne(r => r.Winner)
            .WithMany()
            .HasForeignKey(r => r.WinnerId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Race>()
            .HasOne(r => r.Second)
            .WithMany()
            .HasForeignKey(r => r.SecondId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Race>()
            .HasOne(r => r.Third)
            .WithMany()
            .HasForeignKey(r => r.ThirdId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Race>()
            .HasOne(r => r.Fourth)
            .WithMany()
            .HasForeignKey(r => r.FourthId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Race>()
            .HasOne(r => r.Fifth)
            .WithMany()
            .HasForeignKey(r => r.FifthId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Race>()
            .HasOne(r => r.Sixth)
            .WithMany()
            .HasForeignKey(r => r.SixthId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Race>()
            .HasOne(r => r.Seventh)
            .WithMany()
            .HasForeignKey(r => r.SeventhId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Race>()
            .HasOne(r => r.Eighth)
            .WithMany()
            .HasForeignKey(r => r.EighthId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Race>()
            .HasOne(r => r.Ninth)
            .WithMany()
            .HasForeignKey(r => r.NinthId)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Race>()
            .HasOne(r => r.Tenth)
            .WithMany()
            .HasForeignKey(r => r.TenthId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MatchPlayer>()
            .HasOne(r => r.Playerone)
            .WithMany()
            .HasForeignKey(r => r.PlayerSeasonId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MatchPlayer>()
            .HasOne(r => r.Playertwo)
            .WithMany()
            .HasForeignKey(r => r.PlayerSeasonIdtwo)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Match>()
            .HasOne(r => r.Teamone)
            .WithMany()
            .HasForeignKey(r => r.TeamSoccerIdone)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Match>()
            .HasOne(r => r.Teamtwo)
            .WithMany()
            .HasForeignKey(r => r.TeamSoccerIdtwo)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MatchSport>()
            .HasOne(r => r.Teamone)
            .WithMany()
            .HasForeignKey(r => r.TeamSportIdone)
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<MatchSport>()
            .HasOne(r => r.Teamtwo)
            .WithMany()
            .HasForeignKey(r => r.TeamSportIdtwo)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
