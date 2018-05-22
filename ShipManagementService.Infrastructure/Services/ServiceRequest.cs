using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Services
{
    public class ServiceRequest : IServiceRequest
    {
        private readonly IMessagePublisher _imessagePublisher;

        public ServiceRequest(IMessagePublisher imessagePublisher)
        {
            _imessagePublisher = imessagePublisher;
        }

        public async Task<Service> SendServiceRequest(Service Service)
        {
            await _imessagePublisher.PublishMessageAsync(MessageTypes.ServiceRequested, Service.Id);
            return Service;
        }
    }
}
