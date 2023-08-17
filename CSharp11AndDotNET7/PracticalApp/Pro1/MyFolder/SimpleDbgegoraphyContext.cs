using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pro1.MyFolder;

public partial class SimpleDbgegoraphyContext : DbContext
{
    public SimpleDbgegoraphyContext()
    {
    }

    public SimpleDbgegoraphyContext(DbContextOptions<SimpleDbgegoraphyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Continent> Continents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryLanguage> CountryLanguages { get; set; }

    public virtual DbSet<CountryStat> CountryStats { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SimpleDBGegoraphy;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Continent>(entity =>
        {
            entity.HasKey(e => e.ContinentId).HasName("PK__Continen__D7EBDB6F79506BC3");

            entity.Property(e => e.ContinentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__D320769C0154BABD");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
            entity.Property(e => e.CountryCode2).IsFixedLength();
            entity.Property(e => e.CountryCode3).IsFixedLength();

            entity.HasOne(d => d.Region).WithMany(p => p.Countries).HasConstraintName("FK__Countries__regio__3E52440B");
        });

        modelBuilder.Entity<CountryLanguage>(entity =>
        {
            entity.HasKey(e => new { e.CountryId, e.LanguageId }).HasName("PK__CountryL__E206E0387E97DC3D");

            entity.HasOne(d => d.Country).WithMany(p => p.CountryLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CountryLa__count__440B1D61");

            entity.HasOne(d => d.Language).WithMany(p => p.CountryLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CountryLa__langu__44FF419A");
        });

        modelBuilder.Entity<CountryStat>(entity =>
        {
            entity.HasKey(e => new { e.CountryId, e.Year }).HasName("PK__CountryS__6B29D4A45DC57BEC");

            entity.Property(e => e.Year).IsFixedLength();

            entity.HasOne(d => d.Country).WithMany(p => p.CountryStats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CountrySt__count__412EB0B6");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK__Language__12696A424C037A7F");

            entity.Property(e => e.LanguageId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Regions__15EA90885722DAA9");

            entity.Property(e => e.RegionId).ValueGeneratedNever();

            entity.HasOne(d => d.Continent).WithMany(p => p.Regions).HasConstraintName("FK__Regions__contine__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
