using BurgerRestaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurant.Concrete
{
    public class Menu : Product
    {
        public override string ToString()
        {
            return $"{this.Name} Menu";
        }
    }
}
