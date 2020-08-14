using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void AddLuck(int idPlayer)
        {
            var luck = Items.FirstOrDefault(p => p.Id == idPlayer).Intelligence;
            luck++;
        }

        public void ShowStatistic(int idPlayer)
        {
            // Problem... Pytanie czy jest dobrze w ogóle
            var id = Items.FirstOrDefault(p => p.Id == idPlayer).Id;
            var name = Items.FirstOrDefault(p => p.Id==idPlayer).Name;
            var sex = Items.FirstOrDefault(p => p.Id == idPlayer).Sex;
            var strength = Items.FirstOrDefault(p => p.Id == idPlayer).Strength;
            var luck = Items.FirstOrDefault(p => p.Id == idPlayer).Luck;
            var intelligence = Items.FirstOrDefault(p => p.Id == idPlayer).Intelligence;

            Console.WriteLine($"Imie :{name}" +
                              $"Płeć :{sex}" +
                              $"Siła :{strength}" +
                              $"Szczęście :{luck}" +
                              $"Inteligencja :{intelligence}");
        }

    }
}
