using Microsoft.EntityFrameworkCore;
using Booking.Models;

namespace Booking.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tables
        public DbSet<User> Users => Set<User>();

        public DbSet<Room> Rooms => Set<Room>();

        public DbSet<Booking.Models.Booking> Bookings => Set<Booking.Models.Booking>();

        public DbSet<Payment> Payments => Set<Payment>();


        // Configure Decimal Precision
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>()
                .Property(r => r.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Booking.Models.Booking>()
                .Property(b => b.TotalAmount)
                .HasColumnType("decimal(18,2)");
        }
    }
}