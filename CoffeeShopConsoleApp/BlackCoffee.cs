using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) : base(discount)
        {
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
