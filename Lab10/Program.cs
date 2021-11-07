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

            //var query = from p in context.Products
            //            select p;

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;

            //var query = from p in context.Products
            //            where p.ProductName.Contains("Queso")
            //            select p;

            //var query = from p in context.Products
            //            where p.QuantityPerUnit.Contains("pkg")
            //            select p;

            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;

            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;

            //var query = from p in context.Products
            //            join a in context.Suppliers
            //            on p.SupplierID equals a.SupplierID
            //            where p.Categories.CategoryName == "Dairy Products"
            //            select new 
            //            {
            //                prod_id = p.ProductID,
            //                prod_name = p.ProductName,
            //                prov_name = a.CompanyName
            //            };

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1} \t Proveedor={2}",
            //    prod.prod_id, prod.prod_name, prod.prov_name); 
            //}

            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1}",
                prod.ProductID, prod.ProductName);
            }

            //Products p = new Products();
            //p.ProductName = "Peruvian Coffe";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            //context.Products.InsertOnSubmit(p);
            //Categories c = new Categories();
            //c.CategoryName = "pet food";
            //c.Description = "dogs, cats, rodents, fish";

            //context.Categories.InsertOnSubmit(c);

            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            //var product = (from p in context.Products
            //               where p.ProductID == 78
            //               select p).FirstOrDefault();

            //context.Products.DeleteOnSubmit(product);
            //context.SubmitChanges();



            Console.ReadKey();
        }
    }
}
