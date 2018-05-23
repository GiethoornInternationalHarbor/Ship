using System;
using System.ComponentModel.DataAnnotations;

namespace ShipManagementService.Core.Models
{
    public class Service
    {
        /// <summary>
        /// Gets or sets the identifier.
		/// </summary>
		[Required]
        [Key]
        public Guid Id { get; set; }


        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [Required]
        public double Price { get; set; }
    }
}
