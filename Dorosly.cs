using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Dorosly : TabulaRasa
    {

        public Dorosly(string imie, decimal wiek, string plec) : base(imie, wiek, plec)
        {
            if (wiek > 18 && wiek < 99)
                this.wiek = wiek;
            else
                this.wiek = 20;

            this.głódWsk = 80;
            this.socjalWsk = 80;
            Praca = new Bezrobocie();
        }


        ~Dorosly()
        {
            System.Diagnostics.Trace.WriteLine("Dorosły destructor is called.");
        }
        public Dorosly(string imie, decimal wiek, string plec, int głódWsk, int socjalWsk) : base(imie, wiek, plec)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.plec = plec;
            this.głódWsk = głódWsk;
            this.socjalWsk = socjalWsk;
        }
        public override void Zyj()
        {
            base.Zyj();
            głódWsk -= 2;
            socjalWsk -= 1;

        }
        /*public decimal Zarabiaj(Programista work)
        {

                return work.Wypłata() * wiek * 0.2m;

        }
        */
    }
}
