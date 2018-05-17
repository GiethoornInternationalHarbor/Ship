using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public Task<Service> CreateShipService(Service shipService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteShipService(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> UpdateShipService(Service shipService)
        {
            throw new NotImplementedException();
        }
    }
}
