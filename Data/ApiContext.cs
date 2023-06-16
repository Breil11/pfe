using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using APIExposant.Models;



namespace APIExposant.Data
{
    public partial class ApiContext : DbContext
    {
        public ApiContext()
        {
        }
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achat> achat { get; set; }
        public virtual DbSet<Stand> stand { get; set; }

        public virtual DbSet<Visiteur> visiteur { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achat>(entity =>
            {
                entity.ToTable("Achat");

                entity.HasKey(e => e.IdAchat);

                entity.Property(e => e.StandId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Date).HasColumnType("VARCHAR(100)");
            });



            modelBuilder.Entity<Stand>(entity =>
            {
                entity.ToTable("Stand");



                entity.HasKey(e => e.IdStand);

                entity.Property(e => e.Name).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Prix).ValueGeneratedNever();


            });



            modelBuilder.Entity<Visiteur>(entity =>
            {
                entity.ToTable("Visiteur");



                entity.HasKey(e => e.IdVisiteur);

                entity.Property(e => e.FirstName).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.LastName).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.PhoneNumber);

                entity.Property(e => e.Email).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.ZipCode).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.City).HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Interest).HasColumnType("VARCHAR(200)");





            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
