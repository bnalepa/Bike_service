using Bike_service.Models;
using Microsoft.EntityFrameworkCore;

namespace Bike_service.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BikeRental>()
                .HasKey(br => new {br.BikeId, br.RentalId});
            modelBuilder.Entity<BikeRental>()
                .HasOne(b => b.Bike).WithMany(br => br.BikeRentals).HasForeignKey(b => b.BikeId).IsRequired();
            modelBuilder.Entity<BikeRental>()
                .HasOne(b => b.Rental).WithMany(br => br.BikeRentals).HasForeignKey(b => b.RentalId).IsRequired();

            modelBuilder.Entity<CustomerRental>()
                .HasKey(br => new { br.CustomerId, br.RentalId });
            modelBuilder.Entity<CustomerRental>()
                .HasOne(b => b.Customer).WithMany(br => br.CustomerRentals).HasForeignKey(b => b.CustomerId).IsRequired();
            modelBuilder.Entity<CustomerRental>()
                .HasOne(b => b.Rental).WithMany(br => br.CustomerRentals).HasForeignKey(b => b.RentalId).IsRequired();





        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
