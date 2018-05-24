using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ShipManagementService.Infrastructure.Database;

namespace ContainerService.Infrastructure.Database
{
#if DEBUG

	public class ShipManagementDbContextDesignTimeFactory : IDesignTimeDbContextFactory<ShipManagementDbContext>
	{
		public ShipManagementDbContext CreateDbContext(string[] args)
		{
			var optBuilder = new DbContextOptionsBuilder<ShipManagementDbContext>();
			optBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShipManagementService;Trusted_Connection=True;MultipleActiveResultSets=true");

			return new ShipManagementDbContext(optBuilder.Options);
		}
	}
#endif
}
