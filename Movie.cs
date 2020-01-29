using System;
using System.Collections.Generic;
using System.Text;

namespace exercise2._6
{
    class Movie:Media
    {
        public string Title { get; set; }

        public int Years { get; set; }

        public double Price { get; set; }

        private int stock { get;  }

        private int inStock()
        {
            int stock = 0;
            return stock;
        }
        private void Sell(int qty)
        {

        }



    }
}
