using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Application.Concrete;
using RPGGame.Domain.Entity.Items;
using RPGGame.Domain.Entity.Items.CategoryItems.Weapons;

namespace RPGGame.Application.Managers
{
    public class InventoryManager
    {
        private readonly MenuActionService _actionService;
        private readonly InventoryService _inventoryService;
        private IService<Item> _itemIService;
        InventoryService _iInventoryService2=new InventoryService();


        public InventoryManager(MenuActionService actionService, IService<Item> itemIService, InventoryService inventoryService)
        {
            _actionService = actionService;
            _itemIService = itemIService;
            _inventoryService = inventoryService;
        }

        public Item ShowItemsInInventory(int playerId) //Done no niee.... Musi wykorzystywać klase inventory oraz zawartą w niej liste!
        {
            Console.WriteLine("Przedmioty w twoim plecaku:");

            var itemsInveontory = _inventoryService.GetItemsFromInventory(_itemIService.GetAllItems(), playerId);
            ShowItems(itemsInveontory);
            
            Console.WriteLine("0.Wróć");
            Console.WriteLine("Wybierz przedmiot:");
            Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int selectedoption);
            if (selectedoption == 0)
            {

            }

            var selectedItem = itemsInveontory.FirstOrDefault(p => p.PositionInInventory == selectedoption);
               
            return selectedItem;
        }
        
        public List<Item> ShowItems(List<Item>items) 
        {
            //var items = _itemIService.GetAllItems();
            int howManyItems = 1;
            foreach (var item in items)
            {

                item.PositionInInventory = howManyItems;
                Console.Write($"{item.PositionInInventory}.{item.Name}");
                if (item.IsUse == true)
                {
                    Console.WriteLine($" (Założone)");
                }
                Console.WriteLine();
                howManyItems++;
            }

            return items;
        }

    }
}
