using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models;

public class Customer
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the customer's full name.")]
    [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter the customer's phone number.")]
    [Phone(ErrorMessage = "Please enter a valid phone number.")]
    public string? PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string? Email { get; set; }

    public string? Address { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public Measurement? Measurement { get; set; }
}