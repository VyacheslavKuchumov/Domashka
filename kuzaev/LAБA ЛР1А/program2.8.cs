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
            
            
            int[] numArray = new int[25];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rnd.Next(-50, 50);
            }
            Console.WriteLine("Array is generated:");
            foreach (int num in numArray) { Console.Write(num + "  "); }
            Console.WriteLine();

            Console.Write("Enter an index: ");
            int index = Int32.Parse(Console.ReadLine());
            
            if (numArray[index] % 2 == 0)
            {
                Console.WriteLine(numArray[index]);
                int[] newNumArray = new int[numArray.Length + 1];
                for (int i = 0; i < newNumArray.Length; i++)
                {
                    if (i <= index) { newNumArray[i] = numArray[i]; }
                    else if (i == index+1) { newNumArray[i] = 100; }
                    else if (i > index) { newNumArray[i] = numArray[i - 1]; }

                }
                foreach (int num in newNumArray) { Console.Write(num + "  "); }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(numArray[index]);
                int[] newNumArray = new int[numArray.Length + 1];
                for (int i = 0; i < newNumArray.Length; i++)
                {
                    if (i < index) { newNumArray[i] = numArray[i]; }
                    else if (i == index) { newNumArray[i] = 100; }
                    else if (i > index) { newNumArray[i] = numArray[i - 1]; }

                }
                foreach (int num in newNumArray) { Console.Write(num + "  "); }
                Console.WriteLine();
            }

        }
        
        
        

    }

}
