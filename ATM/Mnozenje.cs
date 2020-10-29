using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Mnozenje : IOperacija
    {
        public int Izracunaj(int a, int b)
        {
            return a * b;
        }
    }
}
