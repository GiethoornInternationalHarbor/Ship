using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Services;
using System.Threading.Tasks;

namespace ShipManagementService.Infrastructure.Services
{
    public class ShipService : IShipService
    {
        private readonly IMessagePublisher _imessagePublisher;

        public ShipService(IMessagePublisher imessagePublisher)
        {
            _imessagePublisher = imessagePublisher;
        }

        public async Task<Ship> ShipNearingHarbor(Ship Ship)
        {
           await _imessagePublisher.PublishMessageAsync(MessageTypes.ShipNearingHarbor, Ship.Id);
           return Ship;
        }

        public async Task<Ship> ShipUndockRequested(Ship Ship)
        {
            await _imessagePublisher.PublishMessageAsync(MessageTypes.ShipUndockRequested, Ship.Id);
            return Ship;
        }
    }
}
