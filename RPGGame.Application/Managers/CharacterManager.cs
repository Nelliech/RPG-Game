using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Application.Concrete;
using RPGGame.Domain.Entity;

namespace RPGGame.Application.Managers
{
    public class CharacterManager
    {
        private readonly MenuActionService _actionService;
        private readonly CharacterService _characterService;
        
        
        public CharacterManager(MenuActionService actionService,CharacterService characterService)
        {
            _characterService = characterService;
            _actionService = actionService;
            
        }

        public int ShowCharacterOptions() //Done
        {
            Console.WriteLine("Witam Przyjacielu! Czas na przygode!");
            var selectOption = _actionService.GetMenuActionsByMenuName("CharacterOptions");
            for (int i = 0; i < selectOption.Count; i++)
            {
                Console.WriteLine($"{selectOption[i].Id} {selectOption[i].Name}");
            }

            Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int selectedResult);


            return selectedResult;
        }
    }
}
