using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 5;

            int c = a + b;
            int d = a * b;
            double f = (double)a / b;
            int k = a - b;

            Console.WriteLine($"Sum = {c}");
            Console.WriteLine($"Multiplication = {d}");
            Console.WriteLine($"Division = {f}");
            Console.WriteLine($"Subtraction = {k}");
        }
    }
}
