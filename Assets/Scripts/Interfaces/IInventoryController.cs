using System;

namespace Bario.Interfaces
{
    public interface IInventoryController
    {
        void ShowInventory(Action callback);
        void HideInventory();
    }
}