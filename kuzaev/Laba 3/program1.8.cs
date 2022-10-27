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
            Money wallet = new Money() { Rubles = 1400, Kopeks = 0};
            Console.WriteLine("BALANCE: " + wallet.Rubles + "," + wallet.Kopeks); 
            wallet.Pay(1300);
        }
        
    }

    class Money
    {
        private uint rubles;
        private byte kopeks;

        public uint Rubles
        {
            get { return rubles; }

            set 
            { 
                if (value > 0)
                {
                    rubles = value;
                }
                else
                {
                    rubles = 0;
                }
                
            }
        }
        public byte Kopeks
        {
            get
            {
                return kopeks;
            }
            set
            {
                if (value > 0 && value<100)
                {
                    kopeks = value;
                }
                else if (value < 0)
                {
                    Kopeks = 0;
                }
                else { kopeks = 0; }
            }
        }

        public void Pay(uint rub, byte kop = 0)
        {
            if (kop < 100 && kop >=0)
            {
                Console.WriteLine("PAYING " + rub + "," + kop + "rub...");
                if (rub > rubles || (rub == rubles && kop > kopeks))
                {
                    Console.WriteLine("INVALID TRANSACTION\nNOT ENOUGH MONEY");
                }
                else
                {
                    Console.WriteLine("TRANSACTION SUCCESFULL");
                    if(kop <= kopeks)
                    {
                        rubles = rubles - rub;
                        kopeks = (byte)(kopeks - kop);
                        Console.WriteLine("BALANCE: " + rubles + "," + kopeks);
                    }
                    else
                    {
                        rubles--;
                        kopeks = (byte)(kopeks + 100);
                        rubles = rubles - rub;
                        kopeks = (byte)(kopeks - kop);
                        Console.WriteLine("BALANCE: " + rubles + "," + kopeks);
                    }
                }
            }
            else
            {
                Console.WriteLine("INVALID TRANSACTION");
            }

        }

    }
}
