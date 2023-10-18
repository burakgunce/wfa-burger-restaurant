using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Abstract
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
