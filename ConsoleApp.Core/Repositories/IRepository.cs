using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Repositories
{
    public interface IRepository<T>
    {
        public Task AddAsync(T model);
        public Task UpdateAsync(T model);
        public Task RemoveAsync(T model);
        public Task<List<T>> GetAll();
        public Task<T> Get(Func<T, bool> exp);

    }
}
