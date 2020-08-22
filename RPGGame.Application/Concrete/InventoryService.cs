using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity.Items;

namespace RPGGame.Application.Concrete
{
    public class InventoryService : BaseService<Item>
    {

        public int AddItemToInventory(Item item, int idPlayer)
        {
            item.InventoryId = idPlayer;

            return item.Id;
        }

        public int DropItemFromInventory(Item item)
        {
            item.InventoryId = 0;

            return item.Id;
        }
    }
}
