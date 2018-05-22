using ShipManagementService.Core.Models;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Services
{
    public interface IShipService
    {
        Task<Ship> ShipUndockRequested(Ship Ship);

        Task<Ship> ShipNearingHarbor(Ship Ship);
    }
}
