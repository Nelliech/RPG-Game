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
         double CurrentlyManaPoint { get; set; }
         double MaximumManaPoint { get; set; }
        //Statistic
         int Strength { get; set; }
         int Luck { get; set; }
         int Intelligence { get; set; }
         int ClassCharacterId { get; set; }
         int Gold { get; set; }
    }
    public class Character : LivingCreature, ICharacter
    {
        public char Sex { get; set; }
        public double CurrentlyManaPoint { get; set; }
        public double MaximumManaPoint { get; set; }
        //Statistic
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Intelligence { get; set; }
        public int ClassCharacterId { get; set; }
        public int Gold { get; set; }

        public Character(int id, string name, char sex, int strength,int luck, int intelligence, int classCharacterId)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Strength = strength;
            Luck = luck;
            Intelligence = intelligence;

            Gold = 100;

            MaximumHealthPoint = 100*(Convert.ToDouble(strength) / 10);
            CurrentlyHealthPoint = MaximumHealthPoint;

            MaximumManaPoint = 100 * (Convert.ToDouble(intelligence) / 10);
            CurrentlyManaPoint = MaximumManaPoint;
        }

        
    }
}
