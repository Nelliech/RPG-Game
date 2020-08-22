using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.Items.CategoryItems.Weapons
{
    public class Weapon : Item
    {
        public double MagicPower { get; set; }
        public double PhysicalStrength { get; set; }
        
        public Weapon() : base()
        {
            
        }
        public Weapon(int id,string name, string description, double magicPower, double physicalStrength)  
            : base(id,name,description)
        {

            MagicPower = magicPower;
            PhysicalStrength = physicalStrength;
            
            CategoryItemId=1;
        }

    }
}
