using System;
using System.Runtime.CompilerServices;
using RPGGame.Application.Concrete;
using RPGGame.Application.Concrete.ItemsServices;
using RPGGame.Application.Managers;
using RPGGame.Helpers;
namespace RPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string startApp = "GRA RPG";
            Helpers.Helpers.CenterText(startApp);

            MenuActionService _actionService = new MenuActionService();
            CharacterService _characterService = new CharacterService();
            ItemService _itemService=new ItemService();
            WeaponService _weaponService = new WeaponService();
            InventoryService _inventoryService=new InventoryService();

            InventoryManager _inventoryManager=new InventoryManager(_actionService,_itemService,_inventoryService);
            CreateCharacterManager _createCharacterManager = new CreateCharacterManager(_actionService, _characterService);

            var playerId =_createCharacterManager.CreateCharacterPanel();

            Console.Clear();

            CharacterManager characterManager = new CharacterManager(_actionService, _characterService);
            
            GameService game= new GameService(_characterService,_itemService,_actionService,characterManager,_weaponService,_inventoryManager,playerId);
            game.Game();
            
        }


    }
}
