using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }
    }
}
