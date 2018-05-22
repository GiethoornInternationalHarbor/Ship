using Microsoft.AspNetCore.Mvc;
using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.App.Controllers
{   
    [Route("api/v1/service")]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRequest _iserviceRequest;

        public ServiceController(IServiceRequest iserviceRequest)
        {
            _iserviceRequest = iserviceRequest;
        }

        [HttpPost]
        public async Task<Service> ServiceRequested(Service Service)
        {
            var Request = await _iserviceRequest.SendServiceRequest(Service);
            return Request;
        }
    }
}
