using Microsoft.EntityFrameworkCore;
using TailorPro.Data;
using TailorPro.Models;

namespace TailorPro.Services;

public class MeasurementService
{
    private readonly ApplicationDbContext _db;
    public MeasurementService(ApplicationDbContext db) => _db = db;

    public Task<Measurement?> GetByCustomerIdAsync(int customerId) =>
        _db.Measurements.FirstOrDefaultAsync(m => m.CustomerId == customerId);

    public async Task SaveAsync(Measurement measurement)
    {
        var existing = await _db.Measurements
            .FirstOrDefaultAsync(m => m.CustomerId == measurement.CustomerId);
        if (existing is null)
            _db.Measurements.Add(measurement);
        else
        {
            existing.Chest         = measurement.Chest;
            existing.Waist         = measurement.Waist;
            existing.Hips          = measurement.Hips;
            existing.ShoulderWidth = measurement.ShoulderWidth;
            existing.SleeveLength  = measurement.SleeveLength;
            existing.TrouserLength = measurement.TrouserLength;
            existing.Notes         = measurement.Notes;
            existing.UpdatedAt     = DateTime.UtcNow;
        }
        await _db.SaveChangesAsync();
    }
}
