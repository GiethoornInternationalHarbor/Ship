using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> CreateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> DeleteCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
