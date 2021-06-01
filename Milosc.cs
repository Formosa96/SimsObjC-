using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Milosc
    {
        private TabulaRasa chłop, baba;
        private string plec="niewiadomo";
        private int wylosowana;
        public Milosc(TabulaRasa chłop, TabulaRasa baba)
        {
            this.chłop = chłop;
            this.baba = baba;
            
        }

        ~Milosc()
        {
            System.Diagnostics.Trace.WriteLine("Milosc destructor is called.");
        }
        public Dziecko Poród()
        {

                Random rnd = new Random();
                wylosowana = rnd.Next(0, 10); // dla przedziału 0-10
                if (wylosowana < 5)
                    plec = "mężczyzna";
                else
                    plec = "kobieta";
                return new Dziecko("", 0, plec);
            

        }
    }
}
