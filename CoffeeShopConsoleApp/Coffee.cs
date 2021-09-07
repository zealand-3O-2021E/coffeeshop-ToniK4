using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        
        public int Discount { get; set; }

        public Coffee(int discount)
        {
            Discount = discount;
        }

        public virtual int price()
        {
            return 20;
        }

        public abstract string Strength();
    }
}
