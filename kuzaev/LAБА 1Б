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

            Train poezd = new Train();
            bool RUN = true;
            while (RUN)
            {
                Console.WriteLine("If you want to get information about the whole train carriage enter \"1\"\nIf you are interested in a specific seat enter \"2\"\nIf you want to exit enter \"3\"");

                
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 3)
                {
                    RUN = false;

                }
                else if (choice == 1)
                {
                    Console.Write("Enter the number of a train carriage: ");
                    int trCar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Empty seats in the " + trCar + " carriage:");
                    int count = 0;
                    for (int i = 0; i < 36; i++)
                    {

                        if (poezd.seats[trCar - 1, i] == 0)
                        {
                            Console.Write(i + 1 + " ");
                            count++;
                        }
                    }
                    Console.WriteLine("\nTotal: " + count);
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the number of a train carriage: ");
                    int trCar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of a seat: ");
                    int seatNum = Convert.ToInt32(Console.ReadLine());
                    if (poezd.seats[trCar-1, seatNum-1] == 0)
                    {
                        Console.WriteLine("The seat is empty");
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("The seat isn't empty");
                        Console.WriteLine("Press Enter...");
                        Console.ReadLine();
                    }
                }







            }

        }
        
        
        

    }
    internal class Train
    {
        public int[,] seats = new int[18,36];
        public Train()
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
    }

    

}
