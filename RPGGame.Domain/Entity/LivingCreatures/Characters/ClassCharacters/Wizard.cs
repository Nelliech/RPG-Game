using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.ClassCharacters
{
    public class Wizard : Character
    {
        public Wizard(int id, string name, char sex, int strength, int luck, int intelligence)
            : base(id, name, sex, strength, luck, intelligence)
        {

            ClassCharacterId = 2;
        }


    }
}
