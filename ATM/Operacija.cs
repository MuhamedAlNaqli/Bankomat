using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Operacija
    {
        string opcije = "";
        int racun = 50;
        public void Uplata()

        {
            opcije = Console.ReadLine();
            Console.Clear();
            if (opcije == "1")
            {
                Console.WriteLine("1...10 KM");
                Console.WriteLine("2...20 KM");
                Console.WriteLine("3...50 KM");
                Console.WriteLine("4... 100 KM");
                Console.WriteLine("5... 200 KM");
                opcije = Console.ReadLine();
                if (opcije == "1")
                {
                    Console.WriteLine("VAše stanje računa je sada:");
                    Console.WriteLine(racun = racun + 10);
                    Console.WriteLine("Hvala na transkacijama");
                    Console.ReadLine();
                }
                else if (opcije =="2")
                {
                    Console.WriteLine("VAše stanje računa je sada:");
                    Console.WriteLine(racun = racun + 20);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                }
                else if (opcije == "3")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun + 50);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                    
                }
                else if (opcije == "4")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun + 100);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                    
                }
                else if (opcije == "5")
                {
                    Console.WriteLine("Vaše stanje racuna je sada:");
                    Console.WriteLine(racun = racun + 200);
                    Console.WriteLine("Hvala");
                }
            }


        }
        public void Isplata()
        {
            if (opcije == "2")
            {
                Console.WriteLine("1......10KM");
                Console.WriteLine("2......20KM");
                Console.WriteLine("3......50KM");
                Console.WriteLine("4......100KM");
                Console.WriteLine("5......200KM");
                opcije = Console.ReadLine();
                if (opcije == "1")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun - 10);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                   
                }
                else if (opcije == "2")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun - 20);
                    Console.WriteLine("Hvala na transkacijama");
                    Console.ReadLine();
                    
                }
                else if (opcije == "3")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun - 50);
                    Console.WriteLine("Hvala na transkacijama");
                    Console.ReadLine();
                }

                else if (opcije == "4")
                {
                    Console.WriteLine("Vaše stanje računa je sada:");
                    Console.WriteLine(racun = racun - 100);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                }
                else if (opcije == "5")
                {
                    Console.WriteLine("Vaše stanje računa  je sada:");
                    Console.WriteLine(racun = racun - 200);
                    Console.WriteLine("Hvala na transakcijama");
                    Console.ReadLine();
                }


            }

        }
        public void StanjeRacuna()
        {
            Console.WriteLine(racun);
            Console.ReadLine();
        }
    }
}
