using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    abstract class TabulaRasa
    {
        protected string imie;
        protected decimal wiek;
        protected string plec;
        protected int socjalWsk;
        protected int głódWsk;
        public Praca Praca { get; set; }

        public int GłódWsk
        {
            get { return głódWsk; }
            set {
                if (value > 70)
                    głódWsk = 100;
                else głódWsk = value;
                }
        }





        //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        public int Socjal()
        {
            return socjalWsk;
        }
        public int Głód()
        {
            return głódWsk;
        }

        //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        ~TabulaRasa()
        {
            System.Diagnostics.Trace.WriteLine("TabulaRasa destructor is called.");

        }
        public TabulaRasa(string imie, decimal wiek, string plec)
        {
            if (imie.Length > 10)
                this.imie = imie.Substring(0, 10) + "...";
            else
            {
                if (imie.Length == 0)
                {
                    this.imie = "Alex";
                }
                else
                    this.imie = imie;
            }

            this.wiek = wiek;

            if (plec == "mężczyzna" || plec == "kobieta")
                this.plec = plec;
            else
                this.plec = "nieznana";

            socjalWsk = 80;
            głódWsk = 80;
            Praca = new Bezrobocie();
    
        }
        public string Imie
        {
            get { return imie; }
            set { if (value.Length > 10)
                    imie = value.Substring(0, 10) + "...";
                else
                    imie = value;
            }
        }
        public void Dajimie(string imie)
        {
            if (imie.Length > 10)
                this.imie = imie.Substring(0, 10) + "...";
            else
            {
                if (imie.Length == 0)
                {
                    this.imie = "Alex";
                }
                else
                    this.imie = imie;
            }
        }
        public decimal Wiek
        {
            get { return wiek; }
            set
            {
                if (value > 0 && value < 150)
                    wiek = value;
            }
        }


        public string Plec
        {
            get { return plec; }
            set { plec = value; }
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine($"Imię: {imie} Wiek: {wiek} Płeć: {plec} Głód: {głódWsk} Towarzystwo: {socjalWsk}");

        }

        public virtual void Zyj()
        {
            wiek = wiek + 0.2m;
        }

        public virtual bool DajGłód()
        {
            if (głódWsk <= 0)
                return true;
            else
                return false;

        }



        public virtual void Pogadaj()
        {
            if (socjalWsk <= 60)
                socjalWsk += 40;
            else
                socjalWsk = 100;
        }


    }
}
