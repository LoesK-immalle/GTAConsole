﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Dief : Persoon
    {
        public void Steelt(Voertuig voertuig)
        {
            Console.WriteLine("{0} werd gestolen.", voertuig);
        }
    }
}
