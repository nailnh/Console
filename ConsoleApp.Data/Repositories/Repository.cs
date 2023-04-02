using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Core.Models.Base;
using ConsoleApp.Core.Repositories;

namespace ConsoleApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private static List<T> _items = new List<T>();

        public List<T> Items { get { return _items; } }
        public async Task AddAsync(T model)
        {
            Items.Add(model);
        }

        public async Task<T> Get(Func<T, bool> exp)
        {
            return Items.FirstOrDefault(exp);
        }

        public async Task<List<T>> GetAll()
        {
            return Items;
        }

        public async Task RemoveAsync(T model)
        {
            Items.Remove(model);
        }

        public async Task UpdateAsync(T model)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (Items[i].Id == model.Id)
                {
                    _items[i] = model;
                }
            }
        }
    }
}