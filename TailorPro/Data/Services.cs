namespace TailorPro.Data;

public class ServiceItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string BgColor { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;

    public ServiceItem(int id, string name, string description, string category,
                       string duration, decimal price, string bgColor, string icon)
    {
        Id = id;
        Name = name;
        Description = description;
        Category = category;
        Duration = duration;
        Price = price;
        BgColor = bgColor;
        Icon = icon;
    }
}