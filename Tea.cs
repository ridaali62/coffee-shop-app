using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    class Tea : Drink
    {
        public Tea()
        {
            name = "Tea";
            price = 120;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Tea...");
        }
    }

}
