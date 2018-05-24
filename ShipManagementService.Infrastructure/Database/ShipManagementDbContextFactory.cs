using Microsoft.EntityFrameworkCore;

namespace ShipManagementService.Infrastructure.Database
{
    public class ShipManagementDbContextFactory 
    {        
        protected string ConnectionString { get; set; }

        public ShipManagementDbContextFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public ShipManagementDbContext CreateDbContext()
        {
            var optBuilder = new DbContextOptionsBuilder<ShipManagementDbContext>();
            optBuilder.UseSqlServer(ConnectionString);

            return new ShipManagementDbContext(optBuilder.Options);
        }    
    }
}
