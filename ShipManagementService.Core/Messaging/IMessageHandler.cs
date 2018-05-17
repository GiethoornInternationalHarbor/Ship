using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipManagementService.Core.Messaging
{
    public interface IMessageHandler
    {
        /// <summary>
		/// Starts the specified callback.
		/// </summary>
		/// <param name="callback">The callback.</param>
		void Start(IMessageHandlerCallback callback);

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}
