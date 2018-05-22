using Microsoft.EntityFrameworkCore;
using ShipManagementService.Core.Models;

namespace ShipManagementService.Infrastructure.Database
{
    public class ShipManagementDbContext : DbContext
    {
        public ShipManagementDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Service> Service { get; set; }

        public DbSet<Ship> Ship  { get; set; }
    }
}
