using Microsoft.EntityFrameworkCore;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using ShipManagementService.Infrastructure.Database;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class ServiceRepository : IShipServiceRepository
    {
        private readonly ShipManagementDbContextFactory _shipManagementDbContextFactory;
        
        public ServiceRepository(ShipManagementDbContextFactory shipManagementDbContextFactory)
        {
            _shipManagementDbContextFactory = shipManagementDbContextFactory;
        }

        public async Task<Service> CreateShipService(Service shipService)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var CreatingShipService = (await dbContext.Service.AddAsync(shipService)).Entity;
            await dbContext.SaveChangesAsync();
            return CreatingShipService;
        }

        public async Task<Service> UpdateShipService(Service shipService)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var updatedShipService = dbContext.Service.Update(shipService);
            await dbContext.SaveChangesAsync();
            return updatedShipService.Entity;
        }

        public async Task DeleteShipService(Guid id)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var DeletingShipService = new Service() { Id = id };
            dbContext.Entry(DeletingShipService).State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
        }
    }
}
