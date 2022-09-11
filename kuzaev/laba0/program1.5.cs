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
            Console.WriteLine("Enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 for smaller number\nEnter 2 for bigger number\nEnter 3 for arithmetical mean\nEnter 4 for geometric mean");
            int choice = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Here you go:");
            switch (choice)
            {
                case 1:
                    Console.WriteLine(Math.Min(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(Math.Max(num1,num2));
                    break;
                case 3:
                    Console.WriteLine(aMean(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(gMean(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
        static int aMean(int num1, int num2)
        {
            return (num1 + num2) / 2 ;
        }
        static double gMean(int num1, int num2)
        {
            return Math.Sqrt(num1 * num2);
        }





    }
}
