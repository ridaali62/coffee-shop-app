using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    class Coffee : Drink
    {
        public Coffee()
        {
            name = "Coffee";
            price = 200;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Coffee...");
        }
    }

}
