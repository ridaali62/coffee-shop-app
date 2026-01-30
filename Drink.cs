using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    abstract class Drink
    {
        protected string name;
        protected double price;

        public string Name => name;
        public double Price => price;

        public abstract void Prepare();
    }

}
