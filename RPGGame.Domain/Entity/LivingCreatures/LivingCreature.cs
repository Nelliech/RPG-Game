using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity
{
    public class LivingCreature : BaseEntity
    {
        public string Name { get; set; }
        public double CurrentlyHealthPoint { get; set; }
        public double MaximumHealthPoint { get; set; }
    }
}
