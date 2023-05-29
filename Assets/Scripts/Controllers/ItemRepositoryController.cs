using Bario;
using Bario.Interfaces;
using System.Collections.Generic;

namespace Bario.Controllers
{
    public class ItemRepositoryController : BaseController, IItemsRepository
    {
        private Dictionary<int, IItem> _itemsMapById = new();
        public IReadOnlyDictionary<int, IItem> GetItems() => _itemsMapById;

        public ItemRepositoryController(List<ItemConfig> itemConfigs) 
        {
            PopulateItems(ref _itemsMapById, itemConfigs);
        }

        private void PopulateItems(
            ref Dictionary<int, IItem> upgradeHandlersMapByType, 
            List<ItemConfig> itemConfigs)
        {
            foreach (var itemConfig in itemConfigs)
            {
                if (_itemsMapById.ContainsKey(itemConfig.Id))
                    continue;
                upgradeHandlersMapByType.Add(itemConfig.Id, CreateItem(itemConfig));
            }
        }

        private IItem CreateItem(ItemConfig itemConfig)
        {
            return new Item
            {
                Id = itemConfig.Id,
                ItemInfo = new ItemInfo 
                { 
                    Title = itemConfig.Title,
                }
            };
        }

        protected override void OnDisposed()
        {
            _itemsMapById.Clear();
            _itemsMapById = null;
        }
    }
}
