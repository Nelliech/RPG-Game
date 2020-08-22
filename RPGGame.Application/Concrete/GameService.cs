using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using RPGGame.Application.Concrete.ItemsServices;
using RPGGame.Application.Managers;

namespace RPGGame.Application.Concrete
{
    public class GameService
    { 
        private readonly CharacterService _characterService;
        private readonly ItemService _itemService;
        private readonly WeaponService _weaponService;
        private readonly MenuActionService _menuActionService;
        private readonly CharacterManager _characterManager;
        private readonly InventoryManager _inventoryManager;
        
        private int playerId;
        public GameService(CharacterService characterService, ItemService itemService, MenuActionService menuActionService,CharacterManager characterManager,
            WeaponService weaponService,InventoryManager inventoryManager,int playerIdInput)
        {
            _characterService = characterService;
            _itemService = itemService;
            _menuActionService = menuActionService;
            _characterManager = characterManager;
            _weaponService = weaponService;
            _inventoryManager = inventoryManager;
            playerId = playerIdInput;
           
        }

        public void Game()
        {
            ItemManager _itemManager = new ItemManager(_menuActionService, _itemService,_weaponService);
            while (true)
            {


                var selectedOptions = _characterManager.ShowCharacterOptions();
                switch (selectedOptions)
                {
                    case 1://Done
                        _characterService.ShowStatistic(playerId);
                        Console.WriteLine("Wciśnij klawisz żeby wrócić");
                        break;
                    case 2://InProcess
                        var selectedItem = _inventoryManager.ShowItemsInInventory();
                        _itemManager.ShowItemManager(selectedItem);
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



}
