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
            string opcije = "";
            string Pin = "";
            int BrojPokusaja = 2;
            Meni Menimanager = new Meni();
            Authentication Authmanager = new Authentication();
            
            Menimanager.LoginMeni();
            Pin = Console.ReadLine();
            while (!Authmanager.IsPinValid(Pin))
            {
                Pin = Console.ReadLine();
                BrojPokusaja--;

                if (BrojPokusaja == 0)
                    {
                        Console.WriteLine("Vaša kartica je blokriana");
                        Console.ReadLine();
                        return;
                    }
                


                //napraviti ponavljanje menija sve dok korisnik ne odabere izlaz
                //napraviti ponavljanje menija sve dok korisnik ne odabere izlaz
                //izmjeniti funkciju PrikaziMeni da vrati korisnikov odabir sta zeli sa menija i spremiti u kontenjer
                //napraviti novu klasu Operacija u kojoj ce biti smjestene sve stvari: Uplata, Isplata, Izlaz
            }

            while (Authmanager.IsPinValid(Pin))
            {
                Menimanager.PrikaziMeni();
                opcije = Console.ReadLine();
                if (opcije == "4")
                {
                    return;
                }
               
            }
            
        }
    }
}

