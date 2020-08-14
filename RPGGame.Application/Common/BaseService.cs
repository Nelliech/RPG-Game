using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Application.Abstract;
using RPGGame.Domain.Common;

namespace RPGGame.Application.Common
{
    public class BaseService<T> :IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public BaseService()
        {
            Items = new List<T>();
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

        public int GetLastId()
        {
            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }

            return lastId;
        }
        public int AddItem(T items)
        {
            Items.Add(items);
            return items.Id;
        }

        public int EditItem(T items)
        {
            var entity = Items.FirstOrDefault(p => p.Id == items.Id);
            if (entity != null)
            {
                entity = items;
            }

            return entity.Id;
        }

        public void RemoveItem(T items)
        {
            Items.Remove(items);
        }
    }
}
