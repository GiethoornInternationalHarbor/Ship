using Microsoft.EntityFrameworkCore;

namespace ShipManagementService.Infrastructure.Database
{
    public class ShipManagementDbContextFactory 
    {        
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        protected string ConnectionString { get; set; }

        public ShipManagementDbContextFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Creates the database context.
        /// </summary>
        /// <returns></returns>
        public ShipManagementDbContext CreateDbContext()
        {
            var optBuilder = new DbContextOptionsBuilder<ShipManagementDbContext>();
            optBuilder.UseSqlServer(ConnectionString);

            return new ShipManagementDbContext(optBuilder.Options);
        }    
    }
}
