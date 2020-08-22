using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity.Items
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        int CategoryItemId { get; set; }
        int PositionInInventory { get; set; }
        int InventoryId { get; set; }
        bool IsUse { get; set; }
    }
    public class Item : BaseEntity, IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryItemId { get; set; }
        public int PositionInInventory { get; set; }
        public int InventoryId { get; set; }
        public bool IsUse { get; set; }
        public Item(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            IsUse = false;

        }
        public Item(int id, string name, string description,int positionInInventory, int inventoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            PositionInInventory = positionInInventory;
            InventoryId = inventoryId;
        }

        public Item()
        {
        }
    }
}
