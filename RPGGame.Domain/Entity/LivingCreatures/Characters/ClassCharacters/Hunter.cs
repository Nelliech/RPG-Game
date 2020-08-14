﻿using System;
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
            ClassCharacterId = 3;
        }
    }
}