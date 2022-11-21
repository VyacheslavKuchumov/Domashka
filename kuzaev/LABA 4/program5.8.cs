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
            Laba4_1.MakeTextFile("part5");
            Laba4_1.ReadFile("part5");
        }
    }
    class Laba4_1
    {
        
        //часть 1
        public static void MakeTextFile(string fileName)
        {
            Random random = new Random();
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName+".txt", FileMode.Create);
            TextWriter tw = new StreamWriter(fs);
            for (int i = 0; i < 3; i++)
            {
                tw.WriteLine(random.Next(1, 20) + " " + random.Next(1, 20)+ " " + random.Next(1, 20) + " " + random.Next(1, 20) + " "+ random.Next(1,40));
            }
            tw.Close();
            fs.Close();
        }
        public static void ReadFile(string fileName)
        {
           
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName + ".txt", FileMode.Open);
            TextReader tr = new StreamReader(fs);
            int count = 0;
            string[] line1 = tr.ReadLine().Split(' ');
            string[] line2 = tr.ReadLine().Split(' ');
            string[] line3 = tr.ReadLine().Split(' ');


            for (int i = 0; i < 5; i++)
            {
                Console.Write(line1[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(line2[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(line3[i] + " ");
            }
            Console.WriteLine();



            for (int i = 0; i < 5; i++)
            {
                if (Convert.ToInt32(line1[i]) %2 !=0)
                {
                    Console.WriteLine(line1[i]);
                    count++;
                } 
            }
            for (int i = 0; i < 5; i++)
            {
                if (Convert.ToInt32(line2[i]) % 2 != 0)
                {
                    count++;
                    Console.WriteLine(line2[i]);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (Convert.ToInt32(line3[i]) % 2 != 0)
                {
                    count++;
                    Console.WriteLine(line3[i]);
                }
            }
            Console.WriteLine("odd numbers: "+count);



            tr.Close();
            fs.Close();
        }
    }
    

}
