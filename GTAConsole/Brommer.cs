using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Brommer : Voertuig
    {
        public Brommer(): base(ConsoleColor.Magenta)
        {
        }
        public override void Rij()
        {
            Console2.WriteLine("De brommer rijdt...", ConsoleColor.Gray);
        }
        public override void Stuur(int graden)
        {
            Console.WriteLine("De brommer stuurt...");
            base.Stuur(graden);
        }
    }
}
