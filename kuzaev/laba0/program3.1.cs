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
            double otvet = 0;
            Console.WriteLine("Enter a number: ");
            double number = Double.Parse(Console.ReadLine());
            for (double i = 1; i < 1000; i++)
            {
                
                double bruh = Math.Pow(-1, i-1) / Math.Pow(i,i);
                
                if (Math.Abs(bruh) >= number)
                {
                    otvet = otvet + bruh;
                }
                
            }
            Console.WriteLine("The answer is: " + otvet);


        }
        
        

    }
}
