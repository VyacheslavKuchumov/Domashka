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
            Console.WriteLine("Enter a number then enter the k variable: ");
            Console.WriteLine(doAllWork(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));

        }
        
        static bool doAllWork(int num, int k)
        {
            if (num>=10 && num<=99 && num%k==0){
                return true;
            }
            else { return false; }
        }
        

    }
}
