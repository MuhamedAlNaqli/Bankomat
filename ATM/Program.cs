using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        //git pull origin main
        //git status
        //git add .
        //git commit -m "neka poruka"
        //git push origin main  

        static void Main(string[] args)
        {
            int racun = 500;
            string opcije = "";
            string Pin = "";
            int BrojPokusaja = 3;
            Meni Menimanager = new Meni();
            Authentication Authmanager = new Authentication();
            Operacija Menioperacija = new Operacija();

            Menimanager.LoginMeni();
            Pin = Console.ReadLine();
            while (!Authmanager.IsPinValid(Pin))
            {
                
                BrojPokusaja--;
                
                if (BrojPokusaja == 0)
                {
                    Console.WriteLine("Vaša kartica je blokriana");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Unesite vaš pin ponovo:");
                Pin = Console.ReadLine();
            }
            while (Authmanager.IsPinValid(Pin))
            {
                Menimanager.PrikaziMeni();
                opcije = Console.ReadLine();
                Console.Clear();
                if (opcije == "1")
                {
                    Menioperacija.Uplata();
                }
                else if (opcije == "2")
                {
                    Menioperacija.Isplata();
                }
                else if (opcije == "3")
                {
                    Menioperacija.StanjeRacuna();
                }
                else if (opcije == "4")
                {
                    return;
                }


            }

        }
    }
}
//napraviti ponavljanje menija sve dok korisnik ne odabere izlaz
//napraviti ponavljanje menija sve dok korisnik ne odabere izlaz
//izmjeniti funkciju PrikaziMeni da vrati korisnikov odabir sta zeli sa menija i spremiti u kontenjer
//napraviti novu klasu Operacija u kojoj ce biti smjestene sve stvari: Uplata, Isplata, Izlaz

