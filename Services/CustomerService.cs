using Microsoft.EntityFrameworkCore;
using TailorPro.Data;
using TailorPro.Models;

namespace TailorPro.Services;

public class CustomerService
{
    private readonly ApplicationDbContext _db;
    public CustomerService(ApplicationDbContext db) => _db = db;

    public Task<List<Customer>> GetAllAsync() =>
        _db.Customers.Include(c => c.Orders).OrderBy(c => c.FullName).ToListAsync();

    public Task<Customer?> GetByIdAsync(int id) =>
        _db.Customers.Include(c => c.Orders).Include(c => c.Measurement)
           .FirstOrDefaultAsync(c => c.Id == id);

    public async Task AddAsync(Customer customer)
    { _db.Customers.Add(customer); await _db.SaveChangesAsync(); }

    public async Task UpdateAsync(Customer customer)
    { _db.Customers.Update(customer); await _db.SaveChangesAsync(); }

    public async Task DeleteAsync(int id)
    {
        var c = await _db.Customers.FindAsync(id);
        if (c is not null) { _db.Customers.Remove(c); await _db.SaveChangesAsync(); }
    }
}
