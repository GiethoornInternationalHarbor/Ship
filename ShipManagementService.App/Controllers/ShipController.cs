using Microsoft.AspNetCore.Mvc;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.App.Controllers
{
    [Route("api/v1/ship")]
    public class ShipController : ControllerBase
    {
        private readonly IShipService _shipservice;

        public ShipController(IShipService shipService)
        {
            _shipservice = shipService;
        }

        [HttpPost]
        public async Task<Ship> ShipUndockRequested(Ship Ship)
        {
            var ShipUndockRequest = await _shipservice.ShipUndockRequested(Ship);
            return ShipUndockRequest;
        }

        [HttpPost]
        public async Task<Ship> ShipNearingHarbor(Ship Ship)
        {
            var ShipNearby = await _shipservice.ShipNearingHarbor(Ship);
            return ShipNearby;
        }
    }
}
