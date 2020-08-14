using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Application.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }

        int GetLastId();
        int AddItem(T items);

        int EditItem(T items);

        void RemoveItem(T items);

    }
}
