using System.Collections.Generic;
using System;

namespace Bario.Interfaces
{
    public interface IInventoryView
    {
        event EventHandler<IItem> Selected;
        event EventHandler<IItem> Deselected;
        void Display(List<IItem> items);
    }
}
