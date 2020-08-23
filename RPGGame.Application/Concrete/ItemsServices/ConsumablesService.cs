using System;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity.Items;

namespace RPGGame.Application.Concrete.ItemsServices
{
    public class ConsumablesService : BaseService<Consumables>
    {
        public ConsumablesService() :base()
        {
            
        }

        public void ShowStatistic(Consumables consumable)
        {

            Console.WriteLine($"Nazwa Przedmiotu: {consumable.Name}\r\n" +
                              $"Opis: {consumable.Description}\r\n" +
                              $"Ilość {consumable.Quantity}");
            if (consumable.BonusStrength != 0)
            {
                Console.WriteLine($"Bonusowa Siła: +{consumable.BonusStrength}");
            }
            if (consumable.BonusIntelligence != 0)
            {
                Console.WriteLine($"Bonusowa Inteligencja: +{consumable.BonusIntelligence}");
            }
            if (consumable.BonusLuck != 0)
            {
                Console.WriteLine($"Bonusowe Szczęście: +{consumable.BonusLuck}");
            }
            if (consumable.Health != 0)
            {
                Console.WriteLine($"Odnowi: {consumable.Health} punktów życia");
            }
            if (consumable.Mana != 0)
            {
                Console.WriteLine($"Odnowi: {consumable.Mana} punktów many");
            }

        }
    }
}
