namespace BookStore.Dominio
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookStore : DbContext
    {
        public BookStore()
            : base("name=BookStore")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Libro)
                .WithRequired(e => e.Autor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Libro)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Editorial>()
                .HasMany(e => e.Libro)
                .WithRequired(e => e.Editorial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.ISBN10)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.ISBN13)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Peso)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Imagen)
                .IsUnicode(false);
        }
    }
}
