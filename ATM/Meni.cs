using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Meni
    {
        public void LoginMeni()
        {
            Console.WriteLine("Dobro dosli u ATM, molimo vas unesite vaš pin:");
        }
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

    }
}
