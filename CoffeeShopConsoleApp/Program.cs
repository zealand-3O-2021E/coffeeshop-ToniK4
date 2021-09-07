using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffee in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(),
                new Cortado(),
                new Latte()

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price());
                Console.WriteLine("the Strength of the coffee is : "+ coffee.Strength());
            }

            Console.ReadKey();
        }
    }
}
