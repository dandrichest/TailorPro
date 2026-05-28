using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models;

public enum OrderStatus { Pending, InProgress, Completed, Delivered }

public class Order
{
    public int Id { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public DateTime? DueDate { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}