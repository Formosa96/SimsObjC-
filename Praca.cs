using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    abstract class Praca
    {
        ~Praca()
        {
            System.Diagnostics.Trace.WriteLine("Praca destructor is called.");
        }

        public abstract decimal Wypłata();       
        
    }
}
