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
            
            
            List<int> numList = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                numList.Add(rnd.Next(-50, 50));
            }
            Console.WriteLine("List is generated:");
            foreach (int num in numList) { Console.Write(num + " "); }
            Console.WriteLine();
            int numN = rnd.Next(-30, 30);
            Console.WriteLine("Number N: "+ numN);
            
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] > numN)
                {
                    numList.RemoveAt(i);
                }
            }
            foreach (int num in numList) { Console.Write(num + " "); }
            Console.WriteLine();

        }
        
        
        

    }

}
