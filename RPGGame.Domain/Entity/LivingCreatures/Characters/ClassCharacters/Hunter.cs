using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Domain.Entity.ClassCharacters
{
    public class Hunter : Character
    {
        public Hunter(int id, string name, char sex, int strength, int luck, int intelligence,int classCharacterId)
            : base(id, name, sex, strength, luck, intelligence,classCharacterId)
        {

            ClassCharacterId = 3;
        }
    }
}
