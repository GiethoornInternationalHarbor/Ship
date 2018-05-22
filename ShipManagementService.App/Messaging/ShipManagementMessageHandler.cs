using System.Threading.Tasks;
using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Models;
using ShipManagementService.Core.Repositories;
using Utf8Json;

namespace ShipManagementService.App.Messaging
{
    public class ShipManagementMessageHandler : IMessageHandlerCallback
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IShipRepository _shipRepository;
        private readonly IServiceRepository _serviceRepository;
        private readonly IMessagePublisher _messagePublisher;
        
        public ShipManagementMessageHandler(ICustomerRepository customerRepository, IShipRepository shipRepository, 
            IServiceRepository serviceRepository, IMessagePublisher messagePublisher)
        {
            _customerRepository = customerRepository;
            _shipRepository = shipRepository;
            _serviceRepository = serviceRepository;
            _messagePublisher = messagePublisher;            
        }

        public async Task<bool> HandleMessageAsync(MessageTypes messageType, string message)
        {
            switch(messageType)
            {
                case MessageTypes.CustomerCreated:
                {
                    return await HandleCustomerCreated(message);
                }
                case MessageTypes.CustomerUpdated:
                {
                    return await HandleCustomerUpdated(message);
                }
                case MessageTypes.CustomerDeleted:
                {
                    return await HandleCustomerDeleted(message);
                }
                case MessageTypes.ServiceCreated:
                {
                        return await HandleServiceCreated(message);
                }
                case MessageTypes.ServiceDeleted:
                {
                        return await HandleServiceDeleted(message);
                }
                case MessageTypes.ServiceUpdated:
                {
                        return await HandleServiceUpdated(message);
                }
                case MessageTypes.ShipDocked:
                {
                        return await HandleShipDocked(message);
                }
                case MessageTypes.ShipUndocked:
                {
                        return await HandleShipUndocked(message);
                }
            }
            return true;
        }

        private async Task<bool> HandleCustomerUpdated(string message)
        {
            var receivedCustomer = JsonSerializer.Deserialize<Customer>(message);

            await _customerRepository.UpdateCustomerAsync(receivedCustomer);

            return true;
        }

        private async Task<bool> HandleCustomerCreated(string message)
        {
            var receivedCustomer = JsonSerializer.Deserialize<Customer>(message);

            await _customerRepository.CreateCustomerAsync(receivedCustomer);

            return true;
        }

        private async Task<bool> HandleCustomerDeleted(string message)
        {
            var receivedCustomer = JsonSerializer.Deserialize<Customer>(message);

            await _customerRepository.DeleteCustomerAsync(receivedCustomer);

            return true;
        }

        private async Task<bool> HandleServiceCreated(string message)
        {
            var Service = JsonSerializer.Deserialize<Service>(message);

            await _messagePublisher.PublishMessageAsync(MessageTypes.ServiceRequested, Service);

            await _serviceRepository.CreateShipService(Service);

            return true;
        }

        private async Task<bool> HandleServiceUpdated(string message)
        {
            var Service = JsonSerializer.Deserialize<Service>(message);

            await _serviceRepository.UpdateShipService(Service);

            return true;
        }

        private async Task<bool> HandleServiceDeleted(string message)
        {
            var Service = JsonSerializer.Deserialize<Service>(message);

            await _serviceRepository.DeleteShipService(Service.Id);

            return true;
        }


        private async Task<bool> HandleShipDocked(string message)
        {
            var Ship = JsonSerializer.Deserialize<Ship>(message);

            await _messagePublisher.PublishMessageAsync(MessageTypes.ShipDocked, Ship.Id);

            await _shipRepository.CreateShip(Ship);

            return true;
        }

        private async Task<bool> HandleShipUndocked(string message)
        {
            var Ship = JsonSerializer.Deserialize<Ship>(message);

            await _messagePublisher.PublishMessageAsync(MessageTypes.ShipUndocked, Ship.Id);

            await _shipRepository.DeleteShip(Ship.Id);

            return true;
        }
    }
}
