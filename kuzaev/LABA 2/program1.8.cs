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
            Train skoriPoezd = new Train("Moscow-St.Petersburg","Moscow","3");
            Train copycatPoezd = new Train(skoriPoezd);
            Console.WriteLine("The original class: "+skoriPoezd.name);
            Console.WriteLine("The copy: "+copycatPoezd.name);
            Console.WriteLine();

            Console.WriteLine(skoriPoezd.Info());
            Console.WriteLine();

            Console.WriteLine(skoriPoezd.ToString());

            PassngrTrain train1 = new PassngrTrain("London-Paddington", "London", "6");
            train1.RandomizeSeats();
            if (train1.seats[2,9] == 1)
            {
                Console.WriteLine("10th seat in a 3rd carriage is taken");  
            }
            else { Console.WriteLine("10th seat in a 3rd carriage is vacant"); }
            train1.PrintSeatsInfo();

        }
        
        
        

    }
    class Train
    {
        public string name;
        public string destination;
        public string platform;

        public Train()
        {

        }
        public Train(string name, string destination, string platform)
        {
            this.name = name;
            this.destination = destination;
            this.platform = platform;
        }

        public Train(Train originalTrain)
        {
            this.name = originalTrain.name;
            this.destination = originalTrain.destination;
            this.platform = originalTrain.platform;
        }
        public string Info()
        {

            return "Train " + name + " is arriving at " + platform + " platform";
        }

        public override string ToString()
        {
            return "Name: "+name+"\n"+"Destination: "+destination+"\n"+"Platform: "+platform+"\n";
        }

        
    }

    class PassngrTrain : Train
    {
        public int[,] seats = new int[4, 10];

        public PassngrTrain(string name, string destination, string platform)
        {
            this.name = name;
            this.destination = destination;
            this.platform = platform;
        }

        public void RandomizeSeats()
        {
            Random rnd = new Random();
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    seats[i, j] = rnd.Next(0, 2);
                }
            }
        }
        public void PrintSeatsInfo()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    Console.Write((i+1)+" "+(j+1)+" ");
                    if (seats[i ,j] == 0)
                    {
                        Console.Write("vacant ");
                    }
                    else
                    {
                        Console.Write("taken ");
                    }
                }
                Console.WriteLine();
            }
        }
    }



}
