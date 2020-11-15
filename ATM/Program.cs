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

        //zadaci
        
        //2.2 Ako pin nije validan ispisati korisniku da nije validan pin 
        //3. Omoguciti korisniku da unosi pin sve dok je netacan
        
        static void Main(string[] args)
        {
            Meni Menimanager = new Meni();
            Authentication Authmanager = new Authentication();
            string Pin = "";


            Menimanager.LoginMeni();

            Pin = Console.ReadLine();

            bool IsPinValid = Authmanager.IsPinValid(Pin);

            if (IsPinValid)
            {
                Menimanager.PrikaziMeni();
            }
        }
    }
}
