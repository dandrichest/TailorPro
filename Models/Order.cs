using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models;

public enum OrderStatus { Pending, InProgress, Completed, Delivered }

public class Order
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter an order description.")]
    [MinLength(5, ErrorMessage = "Description must be at least 5 characters long.")]
    public string Description { get; set; } = string.Empty;

    [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
    public decimal Price { get; set; }

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    [Required]
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "Please select a due date.")]
    public DateTime? DueDate { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Please select a customer for this order.")]
    public int CustomerId { get; set; }

    public Customer Customer { get; set; } = null!;
}