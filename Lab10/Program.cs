using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Origen de los datos
            NorthwndDataContext context = new NorthwndDataContext();

            var query = from p in context.Products
                        select p;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }

            Console.ReadKey();
        }
    }
}
