namespace VideoRental.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using VideoRental.Common.Entities;

    public partial class SqlContext : DbContext
    {
        public SqlContext()
            : base("name=SqlContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Rents)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Videos)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Video>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Video>()
                .HasMany(e => e.Rents)
                .WithRequired(e => e.Video)
                .WillCascadeOnDelete(false);
        }
    }
}
