using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using RPGGame.Domain.Common;

namespace RPGGame.Domain.Entity
{
    public class MenuAction : BaseEntity
     {
        
        public string Name { get; set; }
        public string MenuName { get; set; }

        public MenuAction(int id, string name, string menuName)
        {
            Id = id;
            Name = name;
            MenuName = menuName;
        }
        
    }
}
