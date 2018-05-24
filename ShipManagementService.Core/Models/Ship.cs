using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShipManagementService.Core.Models
{
    public class Ship
    {
        /// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		[Required]
        [Key]
        public string ShipID { get; set; }

        public string ShipName { get; set; }
    }
}
