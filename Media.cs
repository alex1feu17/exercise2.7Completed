using System;
using System.Collections.Generic;
using System.Text;

namespace exercise2._6
{
    class Media
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public int stock { get; protected set; }

        private bool inStock()
        {
           
            return true;
        }
        private void Sell(int qty)
        {

        }
    }
}
