namespace ProjektZaliczeniowyAM
{
    public class Kuchnia
    {
        public int Karm()
        {
            return 30;
        }
        ~Kuchnia()
        {
            System.Diagnostics.Trace.WriteLine("Kuchnia destructor is called.");

        }
    }
}