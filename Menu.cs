using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektZaliczeniowyAM
{
    class Menu
    {
        string[] elementy;// = new string[] { "Lista studentów", "Dodaj studenta", "Edytuj studenta", "Koniec" };

        public Menu(string[] elementyMenu)
        {
            elementy = elementyMenu;
        }

        ~Menu()
        {
            System.Diagnostics.Trace.WriteLine("Menu destructor is called.");
        }
        public int Wyswietl()
        {
            int dlugosc = 0;

            int wybrany = 0;
            Console.CursorVisible = false;
            ConsoleKeyInfo k;
            do
            {

                foreach (string element in elementy)
                {
                    if (element.Length > dlugosc)
                        dlugosc = element.Length;
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < elementy.Length; i++)
                {

                    if (wybrany == i) Console.BackgroundColor = ConsoleColor.Magenta;
                    else Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine(elementy[i].PadRight(dlugosc));
                }
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.UpArrow && wybrany > 0)
                {
                    wybrany--;
                }
                else
                if (k.Key == ConsoleKey.DownArrow && wybrany < elementy.Length - 1)
                {
                    wybrany++;
                }
                else if (k.Key == ConsoleKey.Escape) wybrany = -1;


            } while (!(k.Key == ConsoleKey.Escape || k.Key == ConsoleKey.Enter));

            Console.ResetColor();
            Console.CursorVisible = true;
            return wybrany;
        }
    }
}
