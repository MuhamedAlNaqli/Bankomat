using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Meni
    {
        public void PrikaziMeni()
        {
            Console.WriteLine("Dobro došli u ATM bankomat");
            Console.WriteLine("Izaberite opciju");
            Console.WriteLine("1............ Uplata");
            Console.WriteLine("2............Isplata");
            Console.WriteLine("3............Stanje računa");
            Console.WriteLine("4............Izlaz");
            Console.ReadLine();
            
        }

        //Napraviti klasu Authentication koja ce biti zaduzena za autentikaciju korisnika
            //Unutar klase potrebno dodati funkciju IsPinValid koja prima string, a treba da vrati bool
                //Funkciju implementirati na nacin da provjeri da li je uneseni string == "0000", ako jeste vratiti true, ako nije vratiti false
        
        //git pull origin main
        //git status
        //git add .
        //git commit -m "neka poruka"
        //git push origin main    

    }
}
