using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Dom
    {
        Salon salon;
        Kuchnia kuchnia;
        Łazienka łazienka;

        ~Dom()
        {
            System.Diagnostics.Trace.WriteLine("Dom destructor is called.");

        }
        public Kuchnia Kuchnia
        {
            get { return kuchnia; }
            set { kuchnia = value; }
        }
        public Salon Salon
        {
            get { return salon; }
            set { salon = value; }
        }
        public Łazienka Łazienka
        {
            get { return łazienka; }
            set { łazienka = value; }
        }

        public decimal ZróbKuchnie(decimal pieniadze)
        {

            if (kuchnia == null && pieniadze >= 20000)
            {
                kuchnia = new Kuchnia();
                return pieniadze - 20000;
            }
            else
            {
                Console.WriteLine("Masz już kuchnię lub Cię na nią nie stać.");
                return pieniadze;
            }
        }
        public decimal ZróbSalon(decimal pieniadze)
        {

            if (salon == null && pieniadze >= 50000)
            {
                salon = new Salon();
                return pieniadze - 50000;
            }
            else
            {
                Console.WriteLine("Masz już salon lub Cię na niego nie stać.");
                return pieniadze;

            }
        }
        public decimal ZróbŁazienkę(decimal pieniadze)
        {

            if (łazienka == null && pieniadze >= 30000)
            {
                łazienka = new Łazienka();
                return pieniadze - 30000;
            }
            else
            {
                Console.WriteLine("Masz już łazienkę lub Cię na nią nie stać.");
                return pieniadze;
            }
        }
    }
}
