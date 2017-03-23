using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen()
            : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De vrachtwagen rijdt...", ConsoleColor.Red);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De vrachtwagenchauffeur kijkt in zijn dode-hoek-spiegel");
            base.Stuur(graden);
        }

        public void LaadLeeg()
        {
            Console.WriteLine("De bestuurder laadt de vrachtwagen leeg.")
        }
    }
}
