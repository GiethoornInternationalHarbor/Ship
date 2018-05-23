using System.ComponentModel.DataAnnotations;

namespace ShipManagementService.Core.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public string Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Residence { get; set; }
    }
}
