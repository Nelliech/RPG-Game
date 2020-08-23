using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Application.Concrete;
using RPGGame.Application.Concrete.ItemsServices;
using RPGGame.Domain.Entity;
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
        ConsumablesService _consumablesService = new ConsumablesService();
        private IService<Weapon> _weaponIService;
        public ItemManager(MenuActionService menuActionService, IService<Item> itemIService,IService<Weapon> weaponIService)
        {
            _menuActionService = menuActionService;
            _itemIService = itemIService;
            _weaponIService = weaponIService;
        }

        public void ShowItemManager(Item item)
        {
            List<MenuAction> itemOptionsList=new List<MenuAction>();
            if (item.CategoryItemId == 1)
            {
                itemOptionsList = _menuActionService.GetMenuActionsByMenuName("ItemOptionsWeapon");
            }
            else
            {
                itemOptionsList = _menuActionService.GetMenuActionsByMenuName("ItemOptionsConsumable");

            }

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
                    }else//Other
                    {
                        _consumablesService.ShowStatistic((Consumables)item);
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
