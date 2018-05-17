using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShipManagementService.Core.Messaging;
using ShipManagementService.Core.Repositories;
using ShipManagementService.Infrastructure.Database;
using ShipManagementService.Infrastructure.Messaging;
using ShipManagementService.Infrastructure.Repositories;
using System;

namespace ShipManagementService.Infrastructure.DI
{
    public class DIHelper
    {

        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShipManagementDbContext>(opt => opt.UseSqlServer(configuration.GetSection("DB_CONNECTION_STRING").Value));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IShipRepository, ShipRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();

            services.AddSingleton<IMessageHandler, RabbitMQMessageHandler>((provider) => new RabbitMQMessageHandler(configuration.GetSection("AMQP_URL").Value));
            services.AddTransient<IMessagePublisher, RabbitMQMessagePublisher>((provider) => new RabbitMQMessagePublisher(configuration.GetSection("AMQP_URL").Value));
        }

        public static void OnServicesSetup(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Connecting to database and migrating if required");
            var dbContext = serviceProvider.GetService<ShipManagementDbContext>();
            dbContext.Database.Migrate();
            Console.WriteLine("Completed connecting to database");
        }
    }
}