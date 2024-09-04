using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product Id : ");
            int pid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name : ");
            string pname = Console.ReadLine();

            Console.WriteLine("Enter Unit Price : ");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity : ");
            int quantity = int.Parse(Console.ReadLine());


            int discount;

            if (quantity > 50)
            {
                discount = price * 30 / 100;
            }
            else if(quantity > 30)
            {
                discount = price * 20 / 100;
            }
            else if(quantity > 10)
            {
                discount = price * 10 / 100;
            }


            Console.WriteLine("Total Amount : " + price*quantity);
            Console.WriteLine("Discount Amount : " + discount);
            Console.WriteLine("Final Amount : " + ((price*quantity)-discount));

            Console.ReadLine();
        }
    }
}
