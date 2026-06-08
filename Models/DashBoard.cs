namespace TailorPro.Models;

public class DashboardSummary
{
    public int TotalOrders { get; set; }

    public int PendingOrders { get; set; }

    public int CompletedOrders { get; set; }

    public int DeliveredOrders { get; set; }

    public int TotalCustomers { get; set; }

    public decimal TotalRevenue { get; set; }

    public decimal AverageOrderValue { get; set; }

    public decimal CompletionRate { get; set; }

    public decimal RevenueGrowth { get; set; }
}