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
            Laba4_1.MakeRndBinFile("part1");
            Laba4_1.ReadFile("part1");
        }
    }
    class Laba4_1
    {
        
        //часть 1
        public static void MakeRndBinFile(string fileName)
        {
            Random random = new Random();
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName+".bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < 5; i++)
            {
                bw.Write(random.Next(-30, 30)+"");
            }
            bw.Close();
            fs.Close();
        }
        public static void ReadFile(string fileName)
        {
            List<string> contents = new List<string>();
            FileStream fs = new FileStream("C:/Users/Vyacheslav/source/repos/MyFirstProgram/MyFirstProgram/files/" + fileName + ".bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < 5; i++)
            {
                contents.Add(br.ReadString());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(contents[i]);
            }

            
            for (int i = 1; i < 5; i++)
            {
                contents[i]= contents[i-1] + " " + contents[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(contents[i]);
            }



            br.Close();
            fs.Close();
        }
    }
    

}
