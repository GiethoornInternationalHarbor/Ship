using Microsoft.AspNetCore.Mvc;
using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.App.Controllers
{   
    [Route("api/shipmanagement")]
    public class ShipManagementController : ControllerBase
    {
        private readonly IShipManagementService _shipManagementService;

        public ShipManagementController(IShipManagementService shipManagementService)
        {
            _shipManagementService = shipManagementService;
        }

        [HttpPost]
        public async Task<Service> ServiceRequested(Service Service)
        {
            var Request = await _shipManagementService.SendServiceRequest(Service);
            return Request;
        }
    }
}
