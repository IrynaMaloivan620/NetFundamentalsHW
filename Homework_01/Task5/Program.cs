using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
           // int a = int.Parse(Console.ReadLine());
           int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            double avg = (a + b) / 2.0;

            Console.WriteLine("Average = " + avg);

            int c = Convert.ToInt32(null);
            Console.WriteLine(c);

            int result = Convert.ToInt32(true);
            Console.WriteLine(result);
        }
    }
}
