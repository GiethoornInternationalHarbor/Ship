using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Messaging
{
    public interface IMessageHandlerCallback
    {
        /// <summary>
        /// Handles the message asynchronous.
        /// </summary>
        /// <param name="messageType">Type of the message.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
		Task<bool> HandleMessageAsync(MessageTypes messageType, string message);
    }
}
