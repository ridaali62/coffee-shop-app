using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    class Order
    {
        private Drink drink;
        private int quantity;

        public Order(Drink drink, int quantity)
        {
            this.drink = drink;
            this.quantity = quantity;
        }

        public double CalculateBill()
        {
            return drink.Price * quantity;
        }

        public void PrintBill()
        {
            Console.WriteLine($"Drink: {drink.Name}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total: {CalculateBill()}");
        }
    }

}
