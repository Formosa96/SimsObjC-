using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Prawnik:Praca
    {
        public override decimal Wypłata()
        {
            return 1300;
        }
        ~Prawnik()
        {
            System.Diagnostics.Trace.WriteLine("Prawnik destructor is called.");

        }
    }
}
