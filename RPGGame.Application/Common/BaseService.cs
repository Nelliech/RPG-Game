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
        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }

        public int EditItem(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null)
            {
                entity = item;
            }

            return entity.Id;
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);
        }
        public T GetItemById(int id)    
        {
            var entity = Items.FirstOrDefault(p => p.Id == id);
            return entity;
        }
        public int UpdateItem(T item)
        {
            var entity = Items.FirstOrDefault(p => p.Id == item.Id);
            if (entity != null)
            {
                entity = item;
            }
            return entity.Id;
        }
    }
}
