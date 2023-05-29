using System.Collections.Generic;

namespace Bario.Interfaces
{
    public interface IInventoryModel
    {
        IReadOnlyList<IItem> GetEquippedItens();
        void EquipItem(IItem item);
        void UnEquipItem(IItem item);
    }
}
