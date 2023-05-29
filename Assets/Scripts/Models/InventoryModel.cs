using Bario.Interfaces;
using System.Collections.Generic;

namespace Bario.Models
{
    public class InventoryModel : IInventoryModel
    {
        private static readonly List<IItem> _emptyCollection = new();
        private readonly List<IItem> _items = new();

        public IReadOnlyList<IItem> GetEquippedItens()
        {
            return _items ?? _emptyCollection;
        }
        public void EquipItem(IItem item)
        {
            if (_items.Contains(item)) return;
            _items.Add(item);
        }

        public void UnEquipItem(IItem item)
        {
            if (!_items.Contains(item)) return;
            _items.Remove(item);            
        }
    }
}
