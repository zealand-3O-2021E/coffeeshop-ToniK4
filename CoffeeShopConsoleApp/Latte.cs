using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee , IMilk
    {
        public Latte(int discount) : base(discount)
        {
        }

        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }

    }
}
