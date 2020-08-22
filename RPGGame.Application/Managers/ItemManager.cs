using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Application.Concrete;
using RPGGame.Application.Concrete.ItemsServices;
using RPGGame.Domain.Entity.Items;
using RPGGame.Domain.Entity.Items.CategoryItems.Weapons;

namespace RPGGame.Application.Managers
{
    public class ItemManager
    {
        private readonly MenuActionService _menuActionService;
        public readonly ItemService _itemService;
        public readonly IService<Item> _itemIService;
        WeaponService _weaponService = new WeaponService();
        private IService<Weapon> _weaponIService;
        public ItemManager(MenuActionService menuActionService, IService<Item> itemIService,IService<Weapon> weaponIService)
        {
            _menuActionService = menuActionService;
            _itemIService = itemIService;
            _weaponIService = weaponIService;
        }

        public void ShowItemManager(Item item)
        {
            var itemOptionsList = _menuActionService.GetMenuActionsByMenuName("ItemOptions");
            foreach (var itemOption in itemOptionsList)
            {
                Console.WriteLine($"{itemOption.Id}.{itemOption.Name}");
            }

            Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int selectedOption);

            switch (selectedOption)
            {
                case 1:
                    if (item.CategoryItemId == 1)//Weapon
                    {
                        _weaponService.ShowStatistic((Weapon)item);
                    }else if (item.CategoryItemId == 2)//Other
                    {
                        //Stworz classe dla innych przedmiotów i analogicznie xD
                    }
                    else
                    {

                    }
                        break;
                case 2:
                    if (item.CategoryItemId == 1)
                    {
                        _weaponService.PutWeapon(item.Id);
                    }
                    else
                    {

                    }
                    break;
                case 3:
                    break;
                case 0:
                    break;
                default:
                    break;
                    
            }
        }
    }
}
