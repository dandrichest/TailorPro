using System.ComponentModel.DataAnnotations;

namespace TailorPro.Models;

public class Measurement
{
    public int Id { get; set; }

    [Range(0, 300, ErrorMessage = "Chest measurement must be a positive number between 0 and 300 cm.")]
    public double Chest { get; set; }

    [Range(0, 300, ErrorMessage = "Waist measurement must be a positive number between 0 and 300 cm.")]
    public double Waist { get; set; }

    [Range(0, 300, ErrorMessage = "Hips measurement must be a positive number between 0 and 300 cm.")]
    public double Hips { get; set; }

    [Range(0, 150, ErrorMessage = "Shoulder Width must be a positive number between 0 and 150 cm.")]
    public double ShoulderWidth { get; set; }

    [Range(0, 150, ErrorMessage = "Sleeve Length must be a positive number between 0 and 150 cm.")]
    public double SleeveLength { get; set; }

    [Range(0, 200, ErrorMessage = "Trouser Length must be a positive number between 0 and 200 cm.")]
    public double TrouserLength { get; set; }

    [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
    public string? Notes { get; set; }

    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}