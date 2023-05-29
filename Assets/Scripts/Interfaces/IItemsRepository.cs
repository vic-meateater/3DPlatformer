using System.Collections.Generic;

namespace Bario.Interfaces
{
    public interface IItemsRepository
    {
        IReadOnlyDictionary<int, IItem> GetItems();
    }
}
