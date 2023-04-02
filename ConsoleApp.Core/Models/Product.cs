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
    public class Product : BaseModel
    {
        private static int _id;

        public double Price { get; set; }
        ProductCategory Category { get; set; }

        public Product(string name, double price, ProductCategory category)
        {
            _id++;
            Id = _id;

            Name = name;
            Price = price;
            Category = category;
        }

    }
}
