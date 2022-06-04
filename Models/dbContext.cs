using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbonnementLivres> AbonnementLivres { get; set; }
        public virtual DbSet<Abonnements> Abonnements { get; set; }
        public virtual DbSet<Auteurs> Auteurs { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ImageLivres> ImageLivres { get; set; }
        public virtual DbSet<Livres> Livres { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=db; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbonnementLivres>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Abonnement)
                    .WithMany(p => p.AbonnementLivres)
                    .HasForeignKey(d => d.AbonnementId)
                    .HasConstraintName("FK__Abonnemen__Abonn__440B1D61");

                entity.HasOne(d => d.Livre)
                    .WithMany(p => p.AbonnementLivres)
                    .HasForeignKey(d => d.LivreId)
                    .HasConstraintName("FK__Abonnemen__Livre__4316F928");
            });

            modelBuilder.Entity<Abonnements>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateDebut).HasColumnType("date");

                entity.Property(e => e.DateFin).HasColumnType("date");
            });

            modelBuilder.Entity<Auteurs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ImageLivres>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Livre)
                    .WithMany(p => p.ImageLivres)
                    .HasForeignKey(d => d.LivreId)
                    .HasConstraintName("FK__ImageLivr__Livre__3E52440B");
            });

            modelBuilder.Entity<Livres>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DatePuration).HasColumnType("date");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.HasOne(d => d.Auteur)
                    .WithMany(p => p.Livres)
                    .HasForeignKey(d => d.AuteurId)
                    .HasConstraintName("FK__Livres__AuteurId__3B75D760");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Livres)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Livres__Category__3A81B327");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateNaissance).HasColumnType("date");

                entity.HasOne(d => d.Abonnement)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AbonnementId)
                    .HasConstraintName("FK__Users__Abonnemen__46E78A0C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
