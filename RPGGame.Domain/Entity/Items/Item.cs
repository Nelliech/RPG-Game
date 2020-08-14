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

    }
    public class Item : BaseEntity, IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryItemId { get; set; }
    }
}
