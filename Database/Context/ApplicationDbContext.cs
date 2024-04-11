using Database.Models;
using Database.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StoreItem> StoreItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierStoreItem> SupplierStoreItems { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplierStoreItem>()
                .HasKey(ss => new { ss.StoreId, ss.SupplierId });

            modelBuilder.Entity<SupplierStoreItem>()
                .HasOne(ss => ss.StoreItem)
                .WithMany(s => s.SupplierStoreItems)
                .HasForeignKey(ss => ss.StoreId);

            modelBuilder.Entity<SupplierStoreItem>()
                .HasOne(ss => ss.Supplier)
                .WithMany(s => s.SupplierStoreItems)
                .HasForeignKey(ss => ss.SupplierId);

            var databaseSeeder = new DatabaseSeeder();

            modelBuilder.Entity<StoreItem>().HasData(databaseSeeder.StoreItems);
            modelBuilder.Entity<Supplier>().HasData(databaseSeeder.Suppliers);
            modelBuilder.Entity<SupplierStoreItem>().HasData(databaseSeeder.SupplierStoreItems);
            modelBuilder.Entity<SalesRecord>().HasData(databaseSeeder.SalesRecords);


            base.OnModelCreating(modelBuilder);
        }
    }
}
