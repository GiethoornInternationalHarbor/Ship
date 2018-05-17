using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ShipManagementService.Infrastructure.Database
{
    public class ShipManagementDbContextFactory : IDesignTimeDbContextFactory<ShipManagementDbContext>
    {
        public ShipManagementDbContext CreateDbContext(string[] args)
        {
            var optBuilder = new DbContextOptionsBuilder<ShipManagementDbContext>();
            optBuilder.UseSqlServer("Server=.\\SQL_2017;Database=ShipManagementService;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ShipManagementDbContext(optBuilder.Options);
        }
    }
}
