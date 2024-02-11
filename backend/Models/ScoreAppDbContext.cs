using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

public partial class ScoreAppDbContext : DbContext
{
    public ScoreAppDbContext()
    {
    }

    public ScoreAppDbContext(DbContextOptions<ScoreAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Driverseason> Driverseasons { get; set; }

    public virtual DbSet<Matchplayer> Matchplayers { get; set; }

    public virtual DbSet<Matchsoccer> Matchsoccers { get; set; }

    public virtual DbSet<Matchsport> Matchsports { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Playerseason> Playerseasons { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Teamsoccer> Teamsoccers { get; set; }

    public virtual DbSet<Teamsport> Teamsports { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<Trophy> Trophies { get; set; }

    public virtual DbSet<Winrace> Winraces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:sqlConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("PK__DRIVER__F1B1CD0472FF7678");

            entity.ToTable("DRIVER");

            entity.Property(e => e.Country).HasMaxLength(200);
            entity.Property(e => e.Flag).HasMaxLength(500);
            entity.Property(e => e.LogoTeam).HasMaxLength(500);
            entity.Property(e => e.NameDriver).HasMaxLength(200);
            entity.Property(e => e.Photo).HasMaxLength(500);
            entity.Property(e => e.RacingTeam).HasMaxLength(200);
        });

        modelBuilder.Entity<Driverseason>(entity =>
        {
            entity.HasKey(e => e.DriverSeasonId).HasName("PK__DRIVERSE__05F92D89D5DA3FAB");

            entity.ToTable("DRIVERSEASON");

            entity.Property(e => e.LogoTeam).HasMaxLength(500);
            entity.Property(e => e.NameDriverSeason).HasMaxLength(200);
            entity.Property(e => e.Photo).HasMaxLength(500);

            entity.HasOne(d => d.Season).WithMany(p => p.Driverseasons)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__DRIVERSEA__Seaso__60A75C0F");
        });

        modelBuilder.Entity<Matchplayer>(entity =>
        {
            entity.HasKey(e => e.MatchId).HasName("PK__MATCHPLA__4218C817F22EBCAD");

            entity.ToTable("MATCHPLAYER");

            entity.Property(e => e.GameS1p1).HasColumnName("GameS1P1");
            entity.Property(e => e.GameS1p2).HasColumnName("GameS1P2");
            entity.Property(e => e.GameS2p1).HasColumnName("GameS2P1");
            entity.Property(e => e.GameS2p2).HasColumnName("GameS2P2");
            entity.Property(e => e.GameS3p1).HasColumnName("GameS3P1");
            entity.Property(e => e.GameS3p2).HasColumnName("GameS3P2");
            entity.Property(e => e.GameS4p1).HasColumnName("GameS4P1");
            entity.Property(e => e.GameS4p2).HasColumnName("GameS4P2");
            entity.Property(e => e.GameS5p1).HasColumnName("GameS5P1");
            entity.Property(e => e.GameS5p2).HasColumnName("GameS5P2");

            entity.HasOne(d => d.FirstPlayerNavigation).WithMany(p => p.MatchplayerFirstPlayerNavigations)
                .HasForeignKey(d => d.FirstPlayer)
                .HasConstraintName("FK__MATCHPLAY__First__571DF1D5");

            entity.HasOne(d => d.Season).WithMany(p => p.Matchplayers)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__MATCHPLAY__Seaso__59063A47");

            entity.HasOne(d => d.SecondPlayerNavigation).WithMany(p => p.MatchplayerSecondPlayerNavigations)
                .HasForeignKey(d => d.SecondPlayer)
                .HasConstraintName("FK__MATCHPLAY__Secon__5812160E");
        });

        modelBuilder.Entity<Matchsoccer>(entity =>
        {
            entity.HasKey(e => e.MatchId).HasName("PK__MATCHSOC__4218C8174D552845");

            entity.ToTable("MATCHSOCCER");

            entity.Property(e => e.Gteam1).HasColumnName("GTeam1");
            entity.Property(e => e.Gteam2).HasColumnName("GTeam2");

            entity.HasOne(d => d.FirstTeamNavigation).WithMany(p => p.MatchsoccerFirstTeamNavigations)
                .HasForeignKey(d => d.FirstTeam)
                .HasConstraintName("FK__MATCHSOCC__First__4D94879B");

            entity.HasOne(d => d.Season).WithMany(p => p.Matchsoccers)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__MATCHSOCC__Seaso__4F7CD00D");

            entity.HasOne(d => d.SecondTeamNavigation).WithMany(p => p.MatchsoccerSecondTeamNavigations)
                .HasForeignKey(d => d.SecondTeam)
                .HasConstraintName("FK__MATCHSOCC__Secon__4E88ABD4");
        });

        modelBuilder.Entity<Matchsport>(entity =>
        {
            entity.HasKey(e => e.MatchSportId).HasName("PK__MATCHSPO__4218C817AE9B4D82");

            entity.ToTable("MATCHSPORT");

            entity.Property(e => e.Pteam1).HasColumnName("PTeam1");
            entity.Property(e => e.Pteam2).HasColumnName("PTeam2");

            entity.HasOne(d => d.FirstTeamNavigation).WithMany(p => p.MatchsportFirstTeamNavigations)
                .HasForeignKey(d => d.FirstTeam)
                .HasConstraintName("FK__MATCHSPOR__First__52593CB8");

            entity.HasOne(d => d.Season).WithMany(p => p.Matchsports)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__MATCHSPOR__Seaso__5441852A");

            entity.HasOne(d => d.SecondTeamNavigation).WithMany(p => p.MatchsportSecondTeamNavigations)
                .HasForeignKey(d => d.SecondTeam)
                .HasConstraintName("FK__MATCHSPOR__Secon__534D60F1");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__PLAYER__4A4E74C8CB7218B9");

            entity.ToTable("PLAYER");

            entity.Property(e => e.Aopen).HasColumnName("AOpen");
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Flag).HasMaxLength(500);
            entity.Property(e => e.Genre).HasMaxLength(20);
            entity.Property(e => e.NamePlayer).HasMaxLength(200);
            entity.Property(e => e.Photo).HasMaxLength(500);
            entity.Property(e => e.Rgarros).HasColumnName("RGarros");
            entity.Property(e => e.Usopen).HasColumnName("USOpen");
        });

        modelBuilder.Entity<Playerseason>(entity =>
        {
            entity.HasKey(e => e.PlayerSeasonId).HasName("PK__PLAYERSE__B31DEF29F63EAB49");

            entity.ToTable("PLAYERSEASON");

            entity.Property(e => e.NamePlayerSeason).HasMaxLength(200);
            entity.Property(e => e.Photo).HasMaxLength(500);

            entity.HasOne(d => d.Season).WithMany(p => p.Playerseasons)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__PLAYERSEA__Seaso__4AB81AF0");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.RaceId).HasName("PK__RACE__05FBD6B473BC2A57");

            entity.ToTable("RACE");

            entity.Property(e => e.FlagRace).HasMaxLength(500);
            entity.Property(e => e.NameRace).HasMaxLength(200);

            entity.HasOne(d => d.EighthNavigation).WithMany(p => p.RaceEighthNavigations)
                .HasForeignKey(d => d.Eighth)
                .HasConstraintName("FK__RACE__Eighth__6A30C649");

            entity.HasOne(d => d.FifthNavigation).WithMany(p => p.RaceFifthNavigations)
                .HasForeignKey(d => d.Fifth)
                .HasConstraintName("FK__RACE__Fifth__6754599E");

            entity.HasOne(d => d.FourthNavigation).WithMany(p => p.RaceFourthNavigations)
                .HasForeignKey(d => d.Fourth)
                .HasConstraintName("FK__RACE__Fourth__66603565");

            entity.HasOne(d => d.NinthNavigation).WithMany(p => p.RaceNinthNavigations)
                .HasForeignKey(d => d.Ninth)
                .HasConstraintName("FK__RACE__Ninth__6B24EA82");

            entity.HasOne(d => d.Season).WithMany(p => p.Races)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__RACE__SeasonId__6D0D32F4");

            entity.HasOne(d => d.SecondNavigation).WithMany(p => p.RaceSecondNavigations)
                .HasForeignKey(d => d.Second)
                .HasConstraintName("FK__RACE__Second__6477ECF3");

            entity.HasOne(d => d.SeventhNavigation).WithMany(p => p.RaceSeventhNavigations)
                .HasForeignKey(d => d.Seventh)
                .HasConstraintName("FK__RACE__Seventh__693CA210");

            entity.HasOne(d => d.SixthNavigation).WithMany(p => p.RaceSixthNavigations)
                .HasForeignKey(d => d.Sixth)
                .HasConstraintName("FK__RACE__Sixth__68487DD7");

            entity.HasOne(d => d.TenthNavigation).WithMany(p => p.RaceTenthNavigations)
                .HasForeignKey(d => d.Tenth)
                .HasConstraintName("FK__RACE__Tenth__6C190EBB");

            entity.HasOne(d => d.ThirdNavigation).WithMany(p => p.RaceThirdNavigations)
                .HasForeignKey(d => d.Third)
                .HasConstraintName("FK__RACE__Third__656C112C");

            entity.HasOne(d => d.WinnerNavigation).WithMany(p => p.RaceWinnerNavigations)
                .HasForeignKey(d => d.Winner)
                .HasConstraintName("FK__RACE__Winner__6383C8BA");
        });

        modelBuilder.Entity<Season>(entity =>
        {
            entity.HasKey(e => e.SeasonId).HasName("PK__SEASON__C1814E385C9F3871");

            entity.ToTable("SEASON");

            entity.HasOne(d => d.ChampionNavigation).WithMany(p => p.SeasonChampionNavigations)
                .HasForeignKey(d => d.Champion)
                .HasConstraintName("FK__SEASON__Champion__3E52440B");

            entity.HasOne(d => d.SubChampionNavigation).WithMany(p => p.SeasonSubChampionNavigations)
                .HasForeignKey(d => d.SubChampion)
                .HasConstraintName("FK__SEASON__SubChamp__3F466844");

            entity.HasOne(d => d.Tournament).WithMany(p => p.Seasons)
                .HasForeignKey(d => d.TournamentId)
                .HasConstraintName("FK__SEASON__Tourname__403A8C7D");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__TEAM__123AE79978B37572");

            entity.ToTable("TEAM");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Division).HasColumnName("DIVISION");
            entity.Property(e => e.Flag).HasMaxLength(500);
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.NameTeam).HasMaxLength(100);
        });

        modelBuilder.Entity<Teamsoccer>(entity =>
        {
            entity.HasKey(e => e.TeamSoccerId).HasName("PK__TEAMSOCC__CB85D84A72101A22");

            entity.ToTable("TEAMSOCCER");

            entity.Property(e => e.Gc).HasColumnName("GC");
            entity.Property(e => e.Gd).HasColumnName("GD");
            entity.Property(e => e.Gf).HasColumnName("GF");
            entity.Property(e => e.LogoSt).HasMaxLength(500);
            entity.Property(e => e.NameTeamSoccer).HasMaxLength(200);

            entity.HasOne(d => d.Season).WithMany(p => p.Teamsoccers)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__TEAMSOCCE__Seaso__4316F928");
        });

        modelBuilder.Entity<Teamsport>(entity =>
        {
            entity.HasKey(e => e.TeamSportId).HasName("PK__TEAMSPOR__1A0C1FF57F2431D2");

            entity.ToTable("TEAMSPORT");

            entity.Property(e => e.LogoTs).HasMaxLength(500);
            entity.Property(e => e.NameTeamSport).HasMaxLength(200);

            entity.HasOne(d => d.Season).WithMany(p => p.Teamsports)
                .HasForeignKey(d => d.SeasonId)
                .HasConstraintName("FK__TEAMSPORT__Seaso__45F365D3");
        });

        modelBuilder.Entity<Tournament>(entity =>
        {
            entity.HasKey(e => e.TournamentId).HasName("PK__TOURNAME__AC6313133EDCA401");

            entity.ToTable("TOURNAMENT");

            entity.Property(e => e.LogoTournament).HasMaxLength(500);
            entity.Property(e => e.NameTournament).HasMaxLength(100);
        });

        modelBuilder.Entity<Trophy>(entity =>
        {
            entity.HasKey(e => e.TrophyId).HasName("PK__TROPHY__D2991F7990EAD84A");

            entity.ToTable("TROPHY");

            entity.Property(e => e.NameTrophy).HasMaxLength(100);

            entity.HasOne(d => d.Team).WithMany(p => p.Trophies)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK__TROPHY__TeamId__398D8EEE");
        });

        modelBuilder.Entity<Winrace>(entity =>
        {
            entity.HasKey(e => e.WinraceId).HasName("PK__WINRACE__71BA031B525DEB6D");

            entity.ToTable("WINRACE");

            entity.Property(e => e.Driver).HasColumnName("DRIVER");
            entity.Property(e => e.NameRace).HasMaxLength(200);

            entity.HasOne(d => d.DriverNavigation).WithMany(p => p.Winraces)
                .HasForeignKey(d => d.Driver)
                .HasConstraintName("FK__WINRACE__DRIVER__5DCAEF64");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
