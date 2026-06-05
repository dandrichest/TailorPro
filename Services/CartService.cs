using TailorPro.Data;

namespace TailorPro.Services;

public class CartItem
{
    public ServiceItem Service { get; set; } = default!;
    public int Quantity { get; set; } = 1;
}

public class CartService
{
    private readonly List<CartItem> _items = new();

    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();
    public int Count => _items.Sum(i => i.Quantity);
    public decimal Total => _items.Sum(i => i.Service.Price * i.Quantity);

    public event Action? OnChange;

    public void AddToCart(ServiceItem service)
    {
        var existing = _items.FirstOrDefault(i => i.Service.Id == service.Id);
        if (existing is not null)
            existing.Quantity++;
        else
            _items.Add(new CartItem { Service = service });

        OnChange?.Invoke();
    }

    public void RemoveFromCart(int serviceId)
    {
        var item = _items.FirstOrDefault(i => i.Service.Id == serviceId);
        if (item is not null)
            _items.Remove(item);

        OnChange?.Invoke();
    }

    public void Clear()
    {
        _items.Clear();
        OnChange?.Invoke();
    }
}