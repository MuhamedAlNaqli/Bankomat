using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{                         
    class Authentication
    {
        public bool IsPinValid (string pin)
        {

            if (pin != "0000")
            {
                Console.WriteLine("Pin nije tacan!");
                return false;
            }

            return true;
        }
    }
}
