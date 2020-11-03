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

        //zadaci

        
        
        //2.2 Ako pin nije validan ispisati korisniku da nije validan pin 
        //3. Omoguciti korisniku da unosi pin sve dok je netacan
        static string pin = "";
        static Meni Menimanager = new Meni();
        static Authentication authmanager = new Authentication();
        
        static void Main(string[] args)
        {
            Menimanager.LoginMeni();
            pin = Console.ReadLine();
            bool IsPinValid = authmanager.IsPinValid(pin);
           if (IsPinValid)
            {
                Menimanager.PrikaziMeni();
            }
           

            
        }
    }
}
