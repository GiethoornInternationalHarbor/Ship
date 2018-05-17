using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class ShipRepository : IShipRepository
    {
        public Task<Ship> CreateShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        public Task DeleteShip(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Ship> UpdateShip(Ship ship)
        {
            throw new NotImplementedException();
        }
    }
}
