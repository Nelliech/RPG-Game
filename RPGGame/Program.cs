using System;
using System.Runtime.CompilerServices;
using RPGGame.Application.Concrete;
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
            CreateCharacterManager _createCharacterManager = new CreateCharacterManager(_actionService);
            var playerId =_createCharacterManager.CreateCharacterPanel();
            
            

        }

        
    }
}
