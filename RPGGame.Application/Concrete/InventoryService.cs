using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity;
using RPGGame.Domain.Entity.Items;

namespace RPGGame.Application.Concrete
{
    public class InventoryService : BaseService<Inventory>
    {

        public int AddItemToInventory(Item item, int idPlayer)
        {
            item.InventoryId = idPlayer;

            return item.Id;
        }
        public List<Item> AddItemsToInventory(List<Item> items, int idPlayer)
        {
            foreach (var item in items)
            {
                item.InventoryId = idPlayer;
                
            }


            return items;
        }

        public List<Item> GetItemsFromInventory(List<Item>items,int idPlayer)
        {
            var itemList = items.Where(p => p.InventoryId == idPlayer).ToList();
            return itemList;
        }

        public int DropItemFromInventory(Item item)
        {
            item.InventoryId = 0;

            return item.Id;
        }

        public void StartItems()
        {
            
        }
    }
}
