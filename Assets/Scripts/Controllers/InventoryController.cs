using Bario.Interfaces;
using System;
using System.Collections.Generic;

namespace Bario.Controllers
{
    public class InventoryController : BaseController, IInventoryController
    {
        private readonly IInventoryModel _inventoryModel;
        private readonly IItemsRepository _itemsRepository;
        private readonly IInventoryView _inventoryWindowView;

        private ItemRepositoryController _itemRepository;
        public InventoryController(List<ItemConfig> itemConfigs)
        {
            _itemRepository = new ItemRepositoryController(itemConfigs);
        }

        public void ShowInventory(Action callback)
        {
            throw new NotImplementedException();
        }
        public void HideInventory()
        {
            throw new NotImplementedException();
        }

    }
}