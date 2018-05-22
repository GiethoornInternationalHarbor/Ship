using ShipManagementService.Core.Models;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Repositories
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Gets the customer asynchronous.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<Customer> GetCustomerAsync(string email);

        /// <summary>
        /// Creates the customer asynchronous.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        Task<Customer> CreateCustomerAsync(Customer customer);

        /// <summary>
        /// Updates the customer asynchronous.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        Task<Customer> UpdateCustomerAsync(Customer customer);

        /// <summary>
        /// Updates the customer asynchronous.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        Task<Customer> DeleteCustomerAsync(Customer customer);
    }
}
