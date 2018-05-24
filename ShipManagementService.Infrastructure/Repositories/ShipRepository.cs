﻿using Microsoft.EntityFrameworkCore;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using ShipManagementService.Infrastructure.Database;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class ShipRepository : IShipRepository
    {
        private readonly ShipManagementDbContextFactory _shipManagementDbContextFactory;

        public ShipRepository(ShipManagementDbContextFactory shipManagementDbContextFactory)
        {
            _shipManagementDbContextFactory = shipManagementDbContextFactory;
        }

        public Task<Ship> GetShip(string id)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            return dbContext.Ship.LastOrDefaultAsync(x => x.ShipId == id);
        }

        public async Task<Ship> CreateShip(Ship ship)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var CreatingShip = (await dbContext.Ship.AddAsync(ship)).Entity;
            await dbContext.SaveChangesAsync();
            return CreatingShip;
        }

        public async Task DeleteShip(string shipId)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var shipToDelete = new Ship() {ShipId = shipId };
            dbContext.Entry(shipToDelete).State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
        }

        public async Task<Ship> UpdateShip(Ship ship)
        {
            ShipManagementDbContext dbContext = _shipManagementDbContextFactory.CreateDbContext();
            var updateShip = dbContext.Ship.Update(ship);
            await dbContext.SaveChangesAsync();
            return updateShip.Entity;
        }
    }
}
