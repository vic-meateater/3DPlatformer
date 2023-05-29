using Bario;
using System.Collections.Generic;

namespace Bario.Controllers
{
    public class InventoryController : BaseController
    {
        private ItemRepositoryController _itemRepository;
        public InventoryController(List<ItemConfig> itemConfigs)
        {
            _itemRepository = new ItemRepositoryController(itemConfigs);
        }
    }
}