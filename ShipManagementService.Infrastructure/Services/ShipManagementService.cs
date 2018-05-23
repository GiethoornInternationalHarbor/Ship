using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Services
{
    public class ShipManagementService : IShipManagementService
    {
        private readonly IMessagePublisher _messagePublisher;

        public ShipManagementService(IMessagePublisher messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        public async Task<Service> SendServiceRequest(Service Service)
        {
            await _messagePublisher.PublishMessageAsync(MessageTypes.ServiceRequested, Service.Id);
            return Service;
        }
    }
}
