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
            Laba4_1.MakeBinFile("part3");
            Laba4_1.ReadFile("part3");
        }
    }
    class Laba4_1
    {
        
        //часть 1
        public static void MakeBinFile(string fileName)
        {
            Random random = new Random();
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName+".bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("truck");
            bw.Write("5-10");
            bw.Write("guitar");
            bw.Write("3-4");
            bw.Write("tank");
            bw.Write("5-10");
            bw.Write("rc car");
            bw.Write("5-10");
            bw.Write("boat");
            bw.Write("2-5");
            bw.Close();
            fs.Close();
        }
        public static void ReadFile(string fileName)
        {
            List<string> name = new List<string>();
            List<string> age = new List<string>();
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName + ".bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 ==0)
                {
                    name.Add(br.ReadString());
                }
                else
                {
                    age.Add(br.ReadString());
                }
                
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name[i] + " " + age[i]);
            }
            Console.WriteLine("Toys good for a 5yo and a 10yo:");
            for (int i = 0; i < 5; i++)
            {
                if (age[i] == "5-10")
                {
                    Console.WriteLine(name[i]);
                }
                
            }



            br.Close();
            fs.Close();
        }
    }
    

}
