using TailorPro.Data;
using TailorPro.Models;
using Microsoft.EntityFrameworkCore;

namespace TailorPro.Services
{
    public class DashboardService
    {
        private readonly ApplicationDbContext _context;

        public DashboardService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ Total Orders
        public int GetTotalOrders()
        {
            return _context.Orders.Count();
        }

        // ✅ Pending Orders
        public int GetPendingOrders()
        {
            return _context.Orders
                .Count(o => o.Status == OrderStatus.Pending);
        }

        // ✅ Completed Orders
        public int GetCompletedOrders()
        {
            return _context.Orders
                .Count(o => o.Status == OrderStatus.Completed);
        }

        // ✅ Delivered Orders
        public int GetDeliveredOrders()
        {
            return _context.Orders
                .Count(o => o.Status == OrderStatus.Delivered);
        }

        // ✅ Total Revenue
        public decimal GetTotalRevenue()
        {
            return _context.Orders
                .Sum(o => (decimal?)o.Price) ?? 0;
        }
    }
}