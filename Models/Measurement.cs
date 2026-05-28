namespace TailorPro.Models;

public class Measurement
{
    public int Id { get; set; }
    public double Chest { get; set; }
    public double Waist { get; set; }
    public double Hips { get; set; }
    public double ShoulderWidth { get; set; }
    public double SleeveLength { get; set; }
    public double TrouserLength { get; set; }
    public string? Notes { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}