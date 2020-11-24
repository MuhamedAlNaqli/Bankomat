﻿using System;
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
            string Pin = "";
            int BrojPokusaja = 3;
            Meni Menimanager = new Meni();
            Authentication Authmanager = new Authentication();
            
            Menimanager.LoginMeni();
            Pin = Console.ReadLine();
            while (Authmanager.IsPinValid(Pin))
            {
                BrojPokusaja--;

                   
                    if (BrojPokusaja == 0)
                    {
                        Console.WriteLine("Vaša kartica je blokriana");
                        Console.ReadLine();
                        break;
                    }
                    
                    Console.WriteLine("Unijeli ste netacan pin pokusajte ponovo");
                    Console.ReadLine();
            }

            Menimanager.PrikaziMeni();



            bool IsPinValid = Authmanager.IsPinValid(Pin);


            //napraviti ponavljanje unosa pina, max 3 pogresna unosa od korisnika

            if (IsPinValid)
            {
                //napraviti ponavljanje menija sve dok korisnik ne odabere izlaz
                Menimanager.PrikaziMeni();
                //napraviti ponavljanje menija sve dok korisnik ne odabere izlaz

                //izmjeniti funkciju PrikaziMeni da vrati korisnikov odabir sta zeli sa menija i spremiti u kontenjer
                //napraviti novu klasu Operacija u kojoj ce biti smjestene sve stvari: Uplata, Isplata, Izlaz
            }
        }
    }
}
bool IsPinValid = Authmanager.IsPinValid(Pin);
