using ShipManagementService.Core.Models;
using System;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Repositories
{
    public interface IServiceRepository
    {
        /// <summary>
        /// Creates the ship service.
        /// </summary>
        /// <param name="shipService">The ship service.</param>
        /// <returns></returns>
        Task<Service> CreateShipService(Service shipService);

        /// <summary>
        /// Updates the ship service.
        /// </summary>
        /// <param name="shipService">The ship service.</param>
        /// <returns></returns>
        Task<Service> UpdateShipService(Service shipService);

        /// <summary>
        /// Deletes the ship service.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task DeleteShipService(Guid id);
    }
}
