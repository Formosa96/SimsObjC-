using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Bezrobocie :Praca
    {
        public override decimal Wypłata()
        {
            return 0;
        }
        ~Bezrobocie()
        {
            System.Diagnostics.Trace.WriteLine("Bezrobocie destructor is called.");

        }
    }

}
