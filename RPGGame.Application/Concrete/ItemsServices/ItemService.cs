using System.Collections.Generic;
using System.Linq;
using RPGGame.Application.Common;
using RPGGame.Domain.Entity.Items;
using RPGGame.Domain.Entity.Items.CategoryItems.Weapons;

namespace RPGGame.Application.Concrete.ItemsServices
{
    public class ItemService : BaseService<Item>
    {
        public ItemService()
        {
            Initialize();
        }

        public List<Item> StartItems()
        {
            List<Item> listStartItems = Items.Where(p => p.Id <= 3).ToList();

            return listStartItems;
        }

        public void Initialize() 
        {

            //Tu powinny być wszystkie przedmioty którę znajdują się w grze tak na logike.. Potrzeba nogeo property: Przedmiot przypisany do postaci po ID 
            AddItem(new Consumables(1, "Mięsko", "Dobry kawałek miesa", 0, 0, 0, 15, 0, 1));
            AddItem(new Consumables(2, "Mikstura Życia", "Magiczna mikstura odnawia życie", 0, 0, 0, 25, 0, 1));
            AddItem(new Consumables(3, "Mikstura Many", "Magiczna mikstura odnawia mane", 0, 0, 0, 0, 25, 1));

            AddItem(new Weapon(4, "Pierwszy Miecz", "Jakis tam bla bla", 2.5, 9.5));
            AddItem(new Weapon(5, "Pierwszy Łuk", "Jakis tam bla bla", 5.5, 6.5));
            AddItem(new Weapon(6, "Pierwsza Rożdzka", "Jakis taki ładny", 9.5, 2.5));
            


        }

    }
}
