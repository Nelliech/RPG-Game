using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.ClassCharacters
{
    public class Hunter : Character
    {
        public Hunter(int id, string name, char sex)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Strength = 10;
            Luck = 15;
            Intelligence = 5;

            ClassCharacterId = 3;
        }
    }
}
