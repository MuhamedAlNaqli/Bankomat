using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DAL;

namespace ATM
{                         
    class Authentication
    {  
        public bool IsPinValid (string pin)
        {
            var db = new ATMEntities();

            var kartica = db.Kartica.Where(x => x.pinKartice == pin).FirstOrDefault();

            if (kartica == null)
            { 
                Console.WriteLine("Pin nije tacan!");
                Console.ReadLine();
                return false;
            }

            return true;
        }
         
    }
}
