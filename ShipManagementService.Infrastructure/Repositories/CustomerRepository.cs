using Microsoft.EntityFrameworkCore;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using ShipManagementService.Infrastructure.Database;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly ShipManagementDbContextFactory _shipManagementDbFactory;

        public CustomerRepository(ShipManagementDbContextFactory shipManagementDbFactory)
        {
            _shipManagementDbFactory = shipManagementDbFactory;
        }

        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            ShipManagementDbContext dbContext = _shipManagementDbFactory.CreateDbContext();
			var customerToAdd = (await dbContext.Customers.AddAsync(customer)).Entity;
			await dbContext.SaveChangesAsync();
			return customerToAdd;
        }

        public async Task<Customer> DeleteCustomerAsync(Customer customer)
        {
            ShipManagementDbContext dbContext = _shipManagementDbFactory.CreateDbContext();
            var DeletedCustomer = dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
            return DeletedCustomer.Entity;
        }

        public Task<Customer> GetCustomerAsync(string id)
        {
            ShipManagementDbContext dbContext = _shipManagementDbFactory.CreateDbContext();
            return dbContext.Customers.LastOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            ShipManagementDbContext dbContext = _shipManagementDbFactory.CreateDbContext();
            var updatedCustomer = dbContext.Customers.Update(customer);
            await dbContext.SaveChangesAsync();
            return updatedCustomer.Entity;
        }
    }
}
