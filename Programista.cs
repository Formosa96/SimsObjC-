using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Programista:Praca
    {
        public override decimal Wypłata()
        {
            return 1000;
        }
        ~Programista()
        {
            System.Diagnostics.Trace.WriteLine("Programista destructor is called.");

        }
    }
}
