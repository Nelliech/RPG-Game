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

        }
    }
}
