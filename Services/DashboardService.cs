using TailorPro.Data;
using TailorPro.Models;
using Microsoft.EntityFrameworkCore;

namespace TailorPro.Services;

public class DashboardService
{
    private readonly ApplicationDbContext _context;

    public DashboardService(ApplicationDbContext context)
    {
        _context = context;
    }

    public int GetTotalOrders()
        => _context.Orders.Count();

    public int GetPendingOrders()
        => _context.Orders.Count(x => x.Status == OrderStatus.Pending);

    public int GetCompletedOrders()
        => _context.Orders.Count(x => x.Status == OrderStatus.Completed);

    public int GetDeliveredOrders()
        => _context.Orders.Count(x => x.Status == OrderStatus.Delivered);

    public decimal GetTotalRevenue()
        => _context.Orders.Sum(x => (decimal?)x.Price) ?? 0;

    public int GetTotalCustomers()
        => _context.Customers.Count();

    public async Task<List<Customer>> GetLatestCustomersAsync()
    {
        return await _context.Customers
            .OrderByDescending(c => c.CreatedAt)
            .Take(10)
            .ToListAsync();
    }
    
    public decimal GetAverageOrderValue()
    {
        var totalOrders = GetTotalOrders();

        if (totalOrders == 0)
            return 0;

        return GetTotalRevenue() / totalOrders;
    }

    public decimal GetCompletionRate()
    {
        var totalOrders = GetTotalOrders();

        if (totalOrders == 0)
            return 0;

        return (decimal)GetCompletedOrders() / totalOrders * 100;
    }

    public decimal GetRevenueThisMonth()
    {
        var now = DateTime.Now;

        return _context.Orders
            .Where(x =>
                x.OrderDate.Month == now.Month &&
                x.OrderDate.Year == now.Year)
            .Sum(x => (decimal?)x.Price) ?? 0;
    }

    public decimal GetRevenueLastMonth()
    {
        var lastMonth = DateTime.Now.AddMonths(-1);

        return _context.Orders
            .Where(x =>
                x.OrderDate.Month == lastMonth.Month &&
                x.OrderDate.Year == lastMonth.Year)
            .Sum(x => (decimal?)x.Price) ?? 0;
    }

    public decimal GetRevenueGrowth()
    {
        var current = GetRevenueThisMonth();
        var previous = GetRevenueLastMonth();

        if (previous == 0)
            return 100;

        return ((current - previous) / previous) * 100;
    }

    public List<Order> GetRecentOrders()
    {
        return _context.Orders
            .OrderByDescending(x => x.OrderDate)
            .Take(10)
            .ToList();
    }

    public List<Order> GetUpcomingDeliveries()
    {
        return _context.Orders
            .Where(x =>
                x.Status != OrderStatus.Delivered)
            .OrderBy(x => x.DueDate)
            .Take(5)
            .ToList();
    }

    public Dictionary<string, decimal> GetMonthlyRevenue()
    {
        return _context.Orders
            .GroupBy(x => x.OrderDate.Month)
            .Select(x => new
            {
                Month = x.Key,
                Revenue = x.Sum(o => o.Price)
            })
            .ToDictionary(
                x => new DateTime(2025, x.Month, 1)
                    .ToString("MMM"),
                x => x.Revenue
            );
    }

    public DashboardSummary GetDashboardSummary()
    {
        return new DashboardSummary
        {
            TotalOrders = GetTotalOrders(),
            PendingOrders = GetPendingOrders(),
            CompletedOrders = GetCompletedOrders(),
            DeliveredOrders = GetDeliveredOrders(),
            TotalCustomers = GetTotalCustomers(),
            TotalRevenue = GetTotalRevenue(),
            AverageOrderValue = GetAverageOrderValue(),
            CompletionRate = GetCompletionRate(),
            RevenueGrowth = GetRevenueGrowth()
        };
    }
}