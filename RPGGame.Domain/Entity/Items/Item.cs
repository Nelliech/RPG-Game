using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity.Items
{
    public interface IItem
    {
        string Name { get; set; }
        int CategoryItemId { get; set; }
    }
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public bool IsTwoHanded;
        public int CategoryItemId { get; set; }
    }
}
