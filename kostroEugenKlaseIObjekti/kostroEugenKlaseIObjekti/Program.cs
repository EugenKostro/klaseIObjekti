using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.setNaziv("Airbus");
            x380.setDosegLeta(6000);
            x380.setSnagaMotora(2000);

            Console.WriteLine("Naziv: " + x380.getNaziv() +
                "\nSnaga: " + x380.getSnagaMotora() + 
                "\nDoseg leta: " + x380.getDosegLeta());

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);
            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov("MeanMachine", 5000);
            Console.WriteLine(x328.ToString());
            string unos;
            int domet;
            try
            {
                Console.WriteLine("\nUpiši doseg leta aviona " + x328.getNaziv() + ":");
                unos = Console.ReadLine();
                domet = Console.to(unos);
                x328.setDosegLeta(domet);

            }

          

        }
    }
}
