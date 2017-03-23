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
            Persoon rik = new Persoon();
            Dief billy = new Dief();

            billy.Naam = "Bill";
            billy.Rijbewijs = false;

            v.Rij();
            truck.Rij();
            citta.Rij();
            citta.Stuur(28);
            billy.Steelt(citta);
        }
    }
}
