using Microsoft.EntityFrameworkCore;
using TailorPro.Data;
using TailorPro.Models;

namespace TailorPro.Services;

public class OrderService
{
    private readonly ApplicationDbContext _db;
    public OrderService(ApplicationDbContext db) => _db = db;

    public Task<List<Order>> GetAllAsync() =>
        _db.Orders.Include(o => o.Customer).OrderByDescending(o => o.OrderDate).ToListAsync();

    public Task<Order?> GetByIdAsync(int id) =>
        _db.Orders.Include(o => o.Customer).FirstOrDefaultAsync(o => o.Id == id);

    public async Task AddAsync(Order order)
    { _db.Orders.Add(order); await _db.SaveChangesAsync(); }

    public async Task UpdateAsync(Order order)
    { _db.Orders.Update(order); await _db.SaveChangesAsync(); }

    public async Task DeleteAsync(int id)
    {
        var o = await _db.Orders.FindAsync(id);
        if (o is not null) { _db.Orders.Remove(o); await _db.SaveChangesAsync(); }
    }
}
