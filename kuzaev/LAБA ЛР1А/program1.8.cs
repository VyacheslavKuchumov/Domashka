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
            Random rnd = new Random();
            
            
            int[] numArray = new int[10];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Array is generated:");
            foreach (int num in numArray) { Console.Write(num + " "); }
            Console.WriteLine();
            Console.WriteLine("Sum of numbers lower than zero: " + SummaOtric(numArray));


        }
        
        static int SummaOtric(int[] array)
        {
            int output = 0;
            foreach (int num in array)
            {
                
                if (num < 0)
                {
                    output = output + Math.Abs(num);
                }
            }

            return output;
        }

    }
}
