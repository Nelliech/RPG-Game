﻿using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity;

namespace RPGGame.Application.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }

            }

            return result;
        }

        private void Initialize()
        {
            //Po odpaleniu gry
            AddItem(new MenuAction(1, "Stwórz Postać", "Start"));
            AddItem(new MenuAction(2, "Opóść Gre", "Start"));
            //Przy tworzeniu postaci
            AddItem(new MenuAction(1, "Wojownik", "CreateCharacter"));
            AddItem(new MenuAction(2, "Czarodziej", "CreateCharacter"));
            AddItem(new MenuAction(3, "Łowca", "CreateCharacter"));

            //Domyślne opcje gracza
            AddItem(new MenuAction(1, "Zobacz statystyki.", "CharacterOptions"));
            AddItem(new MenuAction(2, "Otwórz plecak", "CharacterOptions"));
            AddItem(new MenuAction(3, "Rozejrzy się", "CharacterOptions"));
            AddItem(new MenuAction(0, "Wyjdź z gry!", "CharacterOptions"));
            //Po wybraniu przedmiotu w plecaku: jeśli można ubrać
            AddItem(new MenuAction(1, "Zobacz statystyki.", "ItemOptionsWeapon"));
            AddItem(new MenuAction(2, "Załóż Przedmiot", "ItemOptionsWeapon"));
            AddItem(new MenuAction(3, "Wyrzuć przedmiot", "ItemOptionsWeapon"));
            AddItem(new MenuAction(0, "Wróc", "ItemOptionsWeapon"));

            AddItem(new MenuAction(1, "Zobacz statystyki.", "ItemOptionsConsumable"));
            AddItem(new MenuAction(2, "Użyj Przedmiot", "ItemOptionsConsumable"));
            AddItem(new MenuAction(3, "Wyrzuć przedmiot", "ItemOptionsConsumable"));
            AddItem(new MenuAction(0, "Wróc", "ItemOptionsConsumable"));
            //




        }
    }
}
