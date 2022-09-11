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
            Console.WriteLine("List of lucky numbers:");
            int i = 1000;
            while (i != 10000)
            {
                if (luckyNumber(i)) { Console.WriteLine(i); } 
                i++;
            }
            

        }
        static bool luckyNumber(int num)
        {
            
            int[] digits = new int[num.ToString().Length];
            for (int i = 0; i < num.ToString().Length; i++)
            {

                digits[i] = Int32.Parse(num.ToString()[i].ToString());
            }
            if (digits[0] + digits[1] == digits[2] + digits[3]) { return true; }

           return false;
        }
        

    }
}
