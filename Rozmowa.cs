using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Rozmowa
    {
        private TabulaRasa os1, os2, os3, os4;
        private List<TabulaRasa> listawew = new List<TabulaRasa>();

        ~Rozmowa()
        {
            System.Diagnostics.Trace.WriteLine("Third's destructor is called.");
        }
        public Rozmowa(TabulaRasa os1, TabulaRasa os2)
        {
            this.os1 = os1;
            this.os2 = os2;
            listawew.Add(os1);
            listawew.Add(os2);

        }
        public Rozmowa(TabulaRasa os1, TabulaRasa os2, TabulaRasa os3)
        {
            this.os1 = os1;
            this.os2 = os2;
            this.os3 = os3;
            listawew.Add(os1);
            listawew.Add(os2);
            listawew.Add(os3);
        }
        public Rozmowa(TabulaRasa os1, TabulaRasa os2, TabulaRasa os3, TabulaRasa os4)
        {
            this.os1 = os1;
            this.os2 = os2;
            this.os3 = os3;
            this.os4 = os4;
            listawew.Add(os1);
            listawew.Add(os2);
            listawew.Add(os3);
            listawew.Add(os4);
        }
        public void WalkieTalkie()
        {
            switch(listawew.Count)
            {

                case 2:
                    os1.Pogadaj();
                    os2.Pogadaj();
                    break;
                case 3:
                    os1.Pogadaj();
                    os2.Pogadaj();
                    os3.Pogadaj();
                    break;
                case 4:
                    os1.Pogadaj();
                    os2.Pogadaj();
                    os3.Pogadaj();
                    os4.Pogadaj();
                    break;
            }
        }
    }
}
