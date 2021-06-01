using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Dziecko:TabulaRasa
    {
        public Dziecko(string imie, decimal wiek, string plec) : base(imie, wiek, plec)
        {
            if (wiek < 18 && wiek >= 0)
                this.wiek = wiek;
            else
                this.wiek = 0;

            this.plec = plec;
            this.głódWsk = 80;
            this.socjalWsk = 80;
            Praca = new Bezrobocie();

        }

        ~Dziecko()
        {
            System.Diagnostics.Trace.WriteLine("Dziecko destructor is called.");
        }


        public override void Zyj()
        {
            base.Zyj();
            głódWsk -= 3;
            socjalWsk -= 2;

        }
    }
}
