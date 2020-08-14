using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.ClassCharacters
{
    public class Wizard : Character
    {
        public Wizard(int id, string name, char sex)
        {
            Id = id;
            Name = name;
            Sex = sex;

            ClassCharacterId = 2;
        }


    }
}
