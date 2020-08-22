using System;
using System.Linq;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity.Items.CategoryItems.Weapons;

namespace RPGGame.Application.Concrete.ItemsServices
{
    public class WeaponService : BaseService<Weapon>
    {
        public WeaponService() : base()
        {
            Initialize();
        }

        public void ShowStatistic(Weapon weapon) // Probleeem
        {
            /*
            //var id = Items.FirstOrDefault(p => p.Id == idItem).Id;
            var name = Items.FirstOrDefault(p => p.Id == idItem).Name;
            var description = Items.FirstOrDefault(p => p.Id == idItem).Description;
            var magicPower = Items.FirstOrDefault(p => p.Id == idItem).MagicPower;
            var physicalStrength = Items.FirstOrDefault(p => p.Id == idItem).PhysicalStrength;
            *
            Console.WriteLine($"Nazwa Przedmiotu: {name}\r\n" +
                              $"Opis: {description}\r\n" +
                              $"Moc Fizyczna Broni: {physicalStrength}\r\n" +
                              $"Moc Magiczna Broni: {magicPower}\r\n");
            */
            Console.WriteLine($"Nazwa Przedmiotu: {weapon.Name}\r\n" +
                              $"Opis: {weapon.Description}\r\n" +
                              $"Moc Fizyczna Broni: {weapon.PhysicalStrength}\r\n" +
                              $"Moc Magiczna Broni: {weapon.MagicPower}\r\n");
        }

        public void PutWeapon(int idItem)
        {
            var allWeapons = Items.Where(p=>p.IsUse==true);
            foreach (var weaponFromAllWeapons in allWeapons)
            {
                weaponFromAllWeapons.IsUse = false;
            }
            var weapon = Items.FirstOrDefault(p => p.Id == idItem);
            weapon.IsUse = true;
        }
        public void Initialize()
        {
            /*
            //Tu powinny być wszystkie przedmioty którę znajdują się w grze tak na logike.. Potrzeba nogeo property: Przedmiot przypisany do postaci po ID 
            AddItem(new Weapon(1, "Magiczny Miecz", "Jakis tam bla bla", 11.3, 32.1));
            AddItem(new Weapon(2, "Łuczek", "Jakis taki ładny", 15.2, 23.1));
            */
        }
    }
}
