using ShipManagementService.Core.Models;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Services
{
    public interface IServiceRequest
    {
        Task<Service> SendServiceRequest(Service Service);
    }
}
