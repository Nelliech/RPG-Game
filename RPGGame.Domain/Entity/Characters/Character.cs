using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity
{
    public interface ICharacter
    {
         string Name { get; set; }
         char Sex { get; set; }
         int Health { get; set; }
         int Mana { get; set; }
        //Statistic
         int Strength { get; set; }
         int Luck { get; set; }
         int Intelligence { get; set; }
         int ClassCharacterId { get; set; }
    }
    public abstract class Character : BaseEntity, ICharacter
    {
        public string Name { get; set; }
        public char Sex { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        //Statistic
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Intelligence { get; set; }
        public int ClassCharacterId { get; set; }

        private bool isPlayer; 
    }
}
