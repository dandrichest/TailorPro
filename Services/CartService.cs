using TailorPro.Data;

namespace TailorPro.Services
{
    public class CartService
    {
        private List<ServiceItem> _items = new();

        // Event to notify when cart changes
        public event Action? OnCartChanged;

        // ✅ Add to cart
        public void AddToCart(ServiceItem item)
        {
            _items.Add(item);
            OnCartChanged?.Invoke();
        }

        // ✅ Get items
        public List<ServiceItem> GetItems()
        {
            return _items;
        }

        // ✅ Count
        public int GetCount()
        {
            return _items.Count;
        }

        // ✅ Clear
        public void ClearCart()
        {
            _items.Clear();
            OnCartChanged?.Invoke();
        }
    }
}
