using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClipperCuts.Models;

namespace ClipperCuts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceCart> ServiceCarts { get; set; } 

        public DbSet<BookingService> BookingServices { get; set; } 

        public DbSet<Booking> Bookings { get; set; } 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 

        }
        public DbSet<ClipperCuts.Models.Service>? Service { get; set; }
    }
}