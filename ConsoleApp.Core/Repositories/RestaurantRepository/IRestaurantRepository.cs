using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Repositories.RestaurantRepository
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task AddAsync();
        Task<List<Restaurant>> GetAllAsync();
        Task<Restaurant> GetAsync(Func<object, bool> value);
        Task<Restaurant> GetAysnc(Func<object, bool> value);
    }
}
