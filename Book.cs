using System;
using System.Collections.Generic;
using System.Text;

namespace exercise2._6
{
    class Book:Media
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

        private int stock { get; }

        private int inStock()
        {
            int stock=0;
            return stock;
        }
        private void Sell(int qty)
        {

        }
    }
}
