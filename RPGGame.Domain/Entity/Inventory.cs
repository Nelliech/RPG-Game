using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;
using RPGGame.Domain.Entity.Items;

namespace RPGGame.Domain.Entity
{
    public class Inventory : BaseEntity
    {
        public List<Item> ItemsInBackpack { get; set; }
        public int PlayerId { get; set; }

        public Inventory(List<Item> itemsInBackpack, int playerId)
        {
            ItemsInBackpack = itemsInBackpack;
            PlayerId = playerId;
        }
    }
}
