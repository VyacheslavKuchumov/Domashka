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
            LinkedList<string> albums = new LinkedList<string>();
            albums.AddLast("Nevermind");
            albums.AddLast("Enema Of The State");
            albums.AddLast("Does This Look Infected?");
            DoingStuff.AddElementAtTheBeginning("Dookie", albums);
            DoingStuff.AddElementAtTheEnd("Please Please Me", albums);
            DoingStuff.PrintLinkedList(albums);
        }
    }
    public class DoingStuff
    {
        public static void AddElementAtTheBeginning(string text, LinkedList<string> loinkedList)
        {
            loinkedList.AddFirst(text);
        }
        public static void AddElementAtTheEnd(string text, LinkedList<string> loinkedList)
        {
            loinkedList.AddLast(text);
        }

        public static void PrintLinkedList(LinkedList<string> loinkedList)
        {
            for (int i = 0; i < loinkedList.Count; i++)
            {
                Console.WriteLine(loinkedList.ElementAt(i));
            }    
        }
    }
    

}
