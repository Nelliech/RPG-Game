﻿using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Concrete;
using RPGGame.Domain.Entity;

namespace RPGGame.Application.Managers
{
    public class CreateCharacterManager // Kontroler co użytkownik co chce zrobić i wywołuje uslugi z serviru. Tu są kroki decyzyjne.
    {
        private readonly MenuActionService _actionService;
        private CharacterService _characterService;

        public CreateCharacterManager(MenuActionService actionService)
        {
            _characterService=new CharacterService();
            _actionService = actionService;
            
        }

        public void CreateCharacter()
        {
            //Class Character
            Console.WriteLine("Wybierz swoją klase postaci !");
            var selectClass = _actionService.GetMenuActionsByMenuName("CreateCharacter");
            for (int i = 0; i < selectClass.Count; i++)
            {
                Console.WriteLine($"{selectClass[i].Id} {selectClass[i].Name}");
            }
            Int32.TryParse(Console.ReadKey().ToString(), out int selectedClass);
            //Name Character
            Console.Write("Podaj imię swojej postaci: ");
            string nameCharacter = Console.ReadLine();
            //Sex Charatcter
            Console.Write("\r\nPodaj płeć swojej postaci\r\n'M'= Mężczyzna\r\n'K'= Kobieta");
            char sexCharacter=Console.ReadKey().KeyChar;
            
            //Statistic Character
            int strength = 0;
            int luck = 0;
            int intelligence = 0;
            switch (selectedClass)
            {
                case '1': //Warrior
                     strength = 15;
                     luck = 10;
                     intelligence = 5;
                    break;
                case '2': //Wizard
                    strength = 10;
                    luck = 5;
                    intelligence = 15;
                    break;
                case '3':
                    strength = 5;
                    luck = 15;
                    intelligence = 10;
                    break;
                default:
                    break;
            }

            int freePoints = 3;
            while (freePoints!=0)
            {
                Console.WriteLine($"1. Siła : {strength} ");
                Console.WriteLine($"2. Szczęście : {luck} ");
                Console.WriteLine($"3. Inteligencja : {intelligence} ");
                int selectedStatistic;
                Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out  selectedStatistic);

                switch (selectedStatistic)
                {
                    case 1:
                        strength++;
                        freePoints--;

                        break;
                    case 2:
                        luck++;
                        freePoints--;
                        break;
                    case 3:
                        intelligence++;
                        freePoints--;
                        break;
                    default:
                        Console.WriteLine("Podana wartość nie jest poprawna! ");
                        break;

                }
            }

            //                                                 ----------------- To do
            //Character character =




        }
    }
}