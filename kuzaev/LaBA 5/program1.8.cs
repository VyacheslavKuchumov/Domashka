using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();
            DoingStuff.AddElement("The Bends", listOfStrings);
            DoingStuff.AddElement("In Rainbows", listOfStrings);
            DoingStuff.AddElement("Kid A", listOfStrings);
            DoingStuff.PrintList(listOfStrings);
        }
    }
    public class DoingStuff
    {
        public static void AddElement(string text, List<string> list)
        {
            list.Add(text);
        }

        public static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }    
        }
    }
    

}
