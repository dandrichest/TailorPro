using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models;

public class Customer
{
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Phone]
    public string? PhoneNumber { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string? Address { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public Measurement? Measurement { get; set; }
}