using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Models
{
    public partial class UdemyContext : DbContext
    {
        public UdemyContext()
        {
        }

        public UdemyContext(DbContextOptions<UdemyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Favoritos> Favoritos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data source=(local);Database=Udemy;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240CFAB31966");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.NomCat)
                    .HasColumnName("nomCat")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__Curso__8551ED05BB97693E");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnName("fechaPublicacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.ImagenUrl)
                    .HasColumnName("imagenUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomCurso)
                    .HasColumnName("nomCurso")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Profesor)
                    .HasColumnName("profesor")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("videoUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Curso__idCategor__1DE57479");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdEst)
                    .HasName("PK__Estudian__3F171ACFB93B8325");

                entity.Property(e => e.IdEst).HasColumnName("idEst");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasennia)
                    .HasColumnName("contrasennia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Favoritos>(entity =>
            {
                entity.HasKey(e => e.IdFavorito)
                    .HasName("PK__Favorito__36472CACBCB8567E");

                entity.Property(e => e.IdFavorito).HasColumnName("idFavorito");

                entity.Property(e => e.IdCurso).HasColumnName("idCurso");

                entity.Property(e => e.IdEst).HasColumnName("idEst");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK__Favoritos__idCur__20C1E124");

                entity.HasOne(d => d.IdEstNavigation)
                    .WithMany(p => p.Favoritos)
                    .HasForeignKey(d => d.IdEst)
                    .HasConstraintName("FK__Favoritos__idEst__21B6055D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
