using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } 

    }
}
