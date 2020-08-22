using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity;
using RPGGame.Domain.Entity.Items;

namespace RPGGame.Application.Concrete
{
    public class CharacterService : BaseService<Character>
    {
        public CharacterService() : base()
        {
            
        }
        public void ShowStatistic(int idPlayer) //Done
        {
           
            
            var id = Items.FirstOrDefault(p => p.Id == idPlayer).Id;
            var name = Items.FirstOrDefault(p => p.Id==idPlayer).Name;
            var sex = Items.FirstOrDefault(p => p.Id == idPlayer).Sex;

            var currentlyHealth = Items.FirstOrDefault(p => p.Id == idPlayer).CurrentlyHealthPoint;
            var maximumHealth = Items.FirstOrDefault(p => p.Id == idPlayer).MaximumHealthPoint;

            var currentlyMana = Items.FirstOrDefault(p => p.Id == idPlayer).CurrentlyManaPoint; //?
            var maximumMana = Items.FirstOrDefault(p => p.Id == idPlayer).MaximumManaPoint;//?

            var strength = Items.FirstOrDefault(p => p.Id == idPlayer).Strength;
            var luck = Items.FirstOrDefault(p => p.Id == idPlayer).Luck;
            var intelligence = Items.FirstOrDefault(p => p.Id == idPlayer).Intelligence;

            Console.WriteLine($"Imie :{name}\r\n" +
                              $"Płeć :{sex}\r\n" +
                              $"Życie:{currentlyHealth}/{maximumHealth}\r\n"+
                              $"Mana:{currentlyMana}/{maximumMana}\r\n" +
                              $"Siła :{strength}\r\n" +
                              $"Szczęście :{luck}\r\n" +
                              $"Inteligencja :{intelligence}\r\n");
        }

        

    }
}
