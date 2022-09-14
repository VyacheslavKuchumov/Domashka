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
            Console.WriteLine("Enter a number: ");
            string num = Console.ReadLine();
            if (Int32.Parse(num) >= 1000 && Int32.Parse(num) <= 10000)
            {
                Console.WriteLine("Digits that bigger than 5: ");
                for (int i = 0; i < num.Length; i++)
                {
                    if (Int32.Parse(num[i].ToString()) > 5) { Console.WriteLine(num[i]); }
                }
            }
            else { Console.WriteLine("Invalid Input"); }
        }
        
    

    }
}
