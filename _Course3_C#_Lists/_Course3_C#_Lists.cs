using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Assignment
{
    class Product
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public string category { get; set; }  




    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { Empid = 201, Name = "Pooja", quantity = 20, category = "Makeup Accessories"};
            Product p2 = new Product() { Empid = 202, Name = "sriharsh", quantity = 30, category = "Laptops" };
            Product p3 = new Product() { Empid = 203, Name = "Hersheys", quantity = 10, category = "Soft Toys" };
            Product p4 = new Product() { Empid = 204, Name = "Luna", quantity =5, category = "Cars" };
            Product p5 = new Product() { Empid = 205, Name = "Kutti", quantity = 25, category = "Dresses" };

            List <Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
}
