using ConsoleApp.Core.Enums;
using ConsoleApp.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Core.Models
{
    public class Restaurant : BaseModel
    {
        private static int _id;
        private object restaurantCategoryEnum;
        public object name;

        public List<Product> Products { get; set; }
        public RestaurantCategory Category { get; set; }

        public Restaurant(RestaurantCategory category)
        {
            _id++;
            Id = _id;
            Products = new List<Product>();
            Category = category;
        }

        public Restaurant(string name, object restaurantCategoryEnum)
        {
            Name = name;
            this.restaurantCategoryEnum = restaurantCategoryEnum;
        }
    }
}
