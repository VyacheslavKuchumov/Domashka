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

            RndArray rndArray = new RndArray();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rndArray.array[0,i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rndArray.array[1,i]+" ");
            }
            Console.WriteLine();
            if ((rndArray.array[0,1] + rndArray.array[1,1]) % 2 == 0)
            {
                Console.WriteLine("The sum of "+ rndArray.array[0, 1] + " and " + rndArray.array[1, 1] + " is even");
            }
            else { Console.WriteLine("The sum of " + rndArray.array[0, 1] + " and " + rndArray.array[1, 1] + " is odd"); }

            Console.Write("Enter which row you want to sum: ");

            int r = Convert.ToInt32(Console.ReadLine()) - 1;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + rndArray.array[r,i];
            }
            Console.WriteLine(sum);  
            if (sum % 10 == 0) { Console.WriteLine("The sum ends with 0"); }
            else { Console.WriteLine("The sum doesn't end with 0"); }
        }
        
        
        

    }
    internal class RndArray
    {
        public int[,] array = new int[2,10];
        public RndArray()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }
    }

    

}
