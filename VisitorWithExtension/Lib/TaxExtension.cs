using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorWithExtension.Lib
{
    static class TaxExtension //Visitor
    {
        public static void AddTax(this ConsumerGood good)
        {
            if (good is Tobacco)
            {
                Console.WriteLine("Eklenen vergi :{0:00.00} ", good.Price * .65f);
                good.Price += good.Price * 0.65f;

            }

            if (good is Alcohol)
            {
                Console.WriteLine("Eklenen vergi :{0:00.00} ", good.Price * .45f);
                good.Price += good.Price * 0.45f;

            }

            if (good is Cheese)
            {
                Console.WriteLine("Eklenen vergi :{0:00.00} ", good.Price * .18f);
                good.Price += good.Price * 0.18f;

            }
        }


    }
}
