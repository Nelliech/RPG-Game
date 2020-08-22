using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.Items
{
    public class Consumables : Item
    {
        public double BonusStrength { get; set; }
        public double BonusIntelligence { get; set; }
        public int BonusLuck { get; set; }
        public double Health { get; set; }
        public double Mana { get; set; }
        public int Quantity { get; set; }

        public Consumables(int id, string name, string description,
            double bonusStrength, double bonusIntelligence, int bonusLuck, double health, double mana, int quantity) 
            : base(id,name,description)
        {
            BonusStrength = bonusStrength;
            BonusIntelligence = bonusIntelligence;
            BonusLuck = bonusLuck;
            Health = health;
            Mana = mana;
            Quantity = quantity;
        }
    }
}
