using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorWithExtension.Lib;

namespace VisitorWithExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Evaluating taxed prices using TaxExtension method.
            List<ConsumerGood> items = new List<ConsumerGood>(3);
            items.Add(new Tobacco(100));
            items.Add(new Alcohol(100));
            items.Add(new Cheese(100));

            foreach (var item in items)
            {
                item.AddTax();

                Console.WriteLine("Vergili Fiyatı : {0:00.00} TL\n",item.Price);
                    
            }
            Console.ReadKey();
        }
    }
}
