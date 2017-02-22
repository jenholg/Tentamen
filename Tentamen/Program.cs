using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamen
{
    interface Grundämne
    {
        int Atomnummer();
        bool Metall();
        string Namn();
    }
    public class Lutetium : Grundämne
    {
        public bool metall { get; set; }
        public int atomnummer { get; set; }
        public int Atomnummer()
        {
            return atomnummer;
        }

        public bool Metall()
        {
            return metall;
        }
        public string Namn()
        {
            return "Lutetium";
        }
    }
    public class Klor : Grundämne
    {
        private bool metall { get; set; }
        private int atomnummer { get; set; }
        public Klor(bool metall, int atomnummer)
        {
            this.metall = metall;
            this.atomnummer = atomnummer;
        }
        public int Atomnummer()
        {
            return atomnummer;
        }
        public bool Metall()
        {
            return metall;
        }
        public string Namn()
        {
            return "Klor";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Grundämne> grundämnen = new List<Grundämne>();
            Lutetium l = new Lutetium();
            Klor k = new Klor(false, 17);
            l.metall = true;
            l.atomnummer = 71;
            grundämnen.Add(l);
            grundämnen.Add(k);
            Console.WriteLine("GRUNDÄMNEN");
            foreach (Grundämne g in grundämnen)
            {
                Console.WriteLine("Namn: " + g.Namn() + ", Atomnummer: " + g.Atomnummer() + ", Metall: " + g.Metall());
            }
            Console.ReadLine();
        }
    }
}
