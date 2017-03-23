using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig truck = new Vrachtwagen();
            Voertuig citta = new Brommer();

            v.Rij();
            truck.Rij();
            citta.Rij();
            citta.Stuur(28);
        }
    }
}
