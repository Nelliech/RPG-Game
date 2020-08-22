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
        public void ShowStatistic(int q) // Probleeem
        {
            

            
        }

        public void Initialize() //Problem bo initializacja obecnie musi być w itemservice i weaponservice zeby wszystko działało. 
        {

            //Tu powinny być wszystkie przedmioty którę znajdują się w grze tak na logike.. Potrzeba nogeo property: Przedmiot przypisany do postaci po ID 
            AddItem(new Weapon(1, "Magiczny Miecz", "Jakis tam bla bla", 11.3, 32.1));
            AddItem(new Weapon(2, "Łuczek", "Jakis taki ładny", 15.2, 23.1));


        }

    }
}
