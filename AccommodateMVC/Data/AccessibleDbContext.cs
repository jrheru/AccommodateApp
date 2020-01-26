using AccommodateMVC.Models;
using Microsoft.EntityFrameworkCore;


namespace AccommodateMVC.Data
{
    public class AccessibleDbContext : DbContext
    {
        public DbSet<AFeature> AFeatures { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessAF> BusinessAFs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source = AccommodateMVC.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessAF>()
                .HasKey(c => new { c.AFeatureID, c.BusinessID });
        }

        public AccessibleDbContext()
        {
        }
    }
}
