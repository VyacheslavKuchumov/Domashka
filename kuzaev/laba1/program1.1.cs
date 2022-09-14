using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double answer;
            Console.WriteLine("Enter the first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Int32.Parse(Console.ReadLine());
            answer = 1 / (Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a - 3 * a * b));
            Console.WriteLine("The answer is: " + answer);

        }
        
        

    }
}
