using System.ComponentModel.DataAnnotations;

namespace ShipManagementService.Core.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public string Id { get; set; }
    }
}
