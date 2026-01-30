using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coffee Shop");
            Console.WriteLine("Select Drink:");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Tea");

            Console.Write("Enter choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            Drink drink;

            if (choice == 1)
            {
                drink = new Coffee();
            }
            else if (choice == 2)
            {
                drink = new Tea();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            drink.Prepare();

            Order order = new Order(drink, quantity);
            order.PrintBill();

            Console.ReadLine();
        }
    }
}
