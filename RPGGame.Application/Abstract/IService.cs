using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Application.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }

        int GetLastId();
        List<T> GetAllItems();
        int AddItem(T item);
        List<T> AddItems(List<T> items);
        int EditItem(T item);
        T GetItemById(int id);
        void RemoveItem(T item);
        int UpdateItem(T item);

    }   
}
