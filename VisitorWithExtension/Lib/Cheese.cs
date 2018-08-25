using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWithExtension.Lib
{//Concrete elements.
    class Cheese : ConsumerGood
    {
        public Cheese(double price = 7)
        {
            Price = price;
           
        }

    }

    class Alcohol : ConsumerGood
    {
        public Alcohol(double price = 20)
        {
            Price = price;
            
        }
    }

    class Tobacco : ConsumerGood
    {
        public Tobacco(double price = 10)
        {
            Price = price;
            
        }
    }
}
