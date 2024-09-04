using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id : ");
            int empid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee name : ");
            string empname = Console.ReadLine();

            Console.WriteLine("Enter Employee Job : ");
            string job = Console.ReadLine();

            Console.WriteLine("Enter salary : ");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("------- Employee Details -------");
            Console.WriteLine("Emp id : " + empid);
            Console.WriteLine("Emp Name : " + empname);
            Console.WriteLine("Emp Job : " + job);
            Console.WriteLine("salary : " + salary);

            Console.ReadLine();
        }
    }
}
