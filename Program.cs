using System;
using System.Collections.Generic;

namespace ProjektZaliczeniowyAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 5);
            Console.WriteLine(" xxxxx xx     xxxxxx xxxxx  xxxxxx    xxxxx  xx  x     x  xxxxx");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("xx     xx xx  xx  xx xx  xx xx       xx      xx  xx   xx xx");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine(" xxxx  xxx    xxxxxx xxxxx  xxxxx     xxx    xx  x  x  x  xxx");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("    xx xx     xx  xx xx  xx xx           xx  xx  x     x     xx");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("xxxxx  xxxxxx xx  xx xxxxx  xxxxxx   xxxxx   xx  x     x xxxxx");

            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Menu Menu1 = new Menu(new string[] { "Stwórz członka rodziny", "Pokaż listę ludzi", "Samouczek", "Przejdź do gry" });
            Menu DzieckoDorosly = new Menu(new string[] { "Dziecko", "Dorosły" });
            Menu PlecCzlowieka = new Menu(new string[] { "Kobieta", "Mezczyzna" }); //Kobieta true
            Menu Sterowanie = new Menu(new string[] { "Żyj", "Karm", "Socjalizuj", "Znajdź pracę","Zarządzaj domem", "Zakończ" });
            Menu Socjal = new Menu(new string[] { "Zrób dziecko", "Rozmawiaj" });
            Menu PracaMenu = new Menu(new string[] { "Prawnik", "Programista" });
            Menu DomMenu = new Menu(new string[] { "Pokaz dom", "Kup Kuchnie", "Kup Łazienkę" , "Kup Salon"});

            TabulaRasa Adam = new Dorosly("Adaś", 20, "Chłop");
            TabulaRasa Ewa = new Dorosly("Ewka", 20, "Baba");

            Dom Dom = new Dom();

            int wybor, wyborDD, wyborPlec, wyborSter, WyborSoc, ileludzi, choose, WyborPraca, WyborDom, karmienie, isnumeric, wiek, ID;

            string name, plec = "nieznana", imie,wiekstring;
            
            decimal pieniadze=0;

            bool isNumeric;

            List<TabulaRasa> lista = new List<TabulaRasa>();

            do
            {

                Console.Clear();
                wybor = Menu1.Wyswietl();

                switch (wybor)
                {
                    case 0:
                        Console.Clear();

                        wyborDD = DzieckoDorosly.Wyswietl();

                        switch (wyborDD)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("Podaj imię dziecka: ");
                                name = Console.ReadLine();

                                Console.WriteLine("Podaj wiek dziecka: ");
                                wiekstring = Console.ReadLine();
                                isNumeric = int.TryParse(wiekstring, out isnumeric);
                                if(isNumeric)
                                    wiek = int.Parse(wiekstring);
                                else
                                {
                                    Console.WriteLine("Nie podałeś liczby. Wiek przydzielony automatycznie.");
                                    wiek = 0;
                                    System.Threading.Thread.Sleep(2000);

                                }
                                Console.Clear();
                                wyborPlec = PlecCzlowieka.Wyswietl();

                                switch (wyborPlec)
                                {
                                    case 0:
                                        Console.Clear();
                                        plec = "kobieta";
                                        break;
                                    case 1:
                                        Console.Clear();
                                        plec = "mężczyzna";
                                        break;
                                }
                                lista.Add(new Dziecko(name, wiek, plec));
                                Console.Clear();

                                break;

                            case 1:
                                Console.Clear();
                                Console.WriteLine("Podaj imię dorosłego: ");
                                name = Console.ReadLine();

                                Console.WriteLine("Podaj wiek dorosłego: ");
                                wiekstring = Console.ReadLine();
                                isNumeric = int.TryParse(wiekstring, out isnumeric);
                                if (isNumeric)
                                    wiek = int.Parse(wiekstring);
                                else
                                {
                                    Console.WriteLine("Nie podałeś liczby. Wiek przydzielony automatycznie.");
                                    wiek = 20;
                                    System.Threading.Thread.Sleep(2000);

                                }

                                Console.WriteLine("Podaj plec dorosłego: ");
                                Console.Clear();

                                wyborPlec = PlecCzlowieka.Wyswietl();

                                switch (wyborPlec)
                                {
                                    case 0:
                                        Console.Clear();
                                        plec = "kobieta";
                                        break;
                                    case 1:
                                        Console.Clear();
                                        plec = "mężczyzna";
                                        break;
                                }
                                lista.Add(new Dorosly(name, wiek, plec));
                                Console.Clear();

                                break;
                        }
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Lista stworzonych osób");
                        foreach (TabulaRasa item in lista)
                        {
                            Console.WriteLine($"Imię członka rodziny: {item.Imie}, wiek: {item.Wiek}, płeć: {item.Plec}.");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1. Żeby przedłużyć linię, stwórz przynajmniej 2 simów.");
                        Console.WriteLine("2. Sim umiera w wieku 80 lat");
                        Console.WriteLine("3. Żeby sim nie umarł z głodu, musisz znaleźć pracę i zarobić na kuchnię, dopiero wtedy masz dostęp do lodówki");
                        Console.ReadKey();
                        break;
                }


            } while (!(wybor == 3 || wybor == -1));

            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            do
            {
                Console.Clear();

                for (int i = 0; i < lista.Count; i++)
                {
                    Console.SetCursorPosition(30, 2 * i);
                    Console.WriteLine($"ID:{i} ");
                    Console.SetCursorPosition(35, 2 * i);
                    lista[i].Wyswietl();
                    Console.SetCursorPosition(18, 1);
                    Console.WriteLine($"$:{pieniadze} ");




                }
                wyborSter = Sterowanie.Wyswietl();
                if (wyborSter == 0)
                {
                    while (true && lista.Count != 0)
                    {
                        Console.CursorVisible = false;

                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) break;

                        Console.Clear();

                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.Clear();

                            for (int k = 0; k < lista.Count; k++)
                            {
                                lista[k].Wyswietl();
                                if (lista[k] is Dorosly)
                                    Console.WriteLine("Dorosły");
                                else
                                    Console.WriteLine("Dziecko");

                            }
                            lista[i].Zyj();

                            if (lista[i] is Dorosly)
                            { pieniadze += lista[i].Praca.Wypłata() * lista[i].Wiek * 0.1m; }

                            Console.SetCursorPosition(70, 0);
                            Console.WriteLine($"$:{pieniadze} ");
                            if (lista[i].Wiek == 18)
                            {
                                lista.Add(new Dorosly(lista[i].Imie, lista[i].Wiek, lista[i].Plec, lista[i].Głód(), lista[i].Socjal()));
                                lista.RemoveAt(i);
                            }

                            if (lista[i].Wiek > 80 || lista[i].DajGłód())
                            {
                                lista.RemoveAt(i);                                
                            }
                            


                        }

                        System.Threading.Thread.Sleep(1000);


                    }
                    Console.CursorVisible = true;

                }
                switch (wyborSter)
                {

                    case 1:
                        Console.Clear();
                        if (Dom.Kuchnia != null)
                        {
                            Console.WriteLine("Podaj ID osoby, którą chcesz nakarmić: ");
                            karmienie = int.Parse(Console.ReadLine());

                            if (karmienie <= (lista.Count - 1) && karmienie >= 0)
                                lista[karmienie].GłódWsk += Dom.Kuchnia.Karm();
                        }
                        else
                            Console.WriteLine("Nie masz kuchni");
                        System.Threading.Thread.Sleep(2000);

                        break;
                    case 2:
                        Console.Clear();
                        WyborSoc = Socjal.Wyswietl();
                        switch (WyborSoc)
                        {
                            case 0:
                                for (int i = 0; i < lista.Count; i++)
                                {
                                    Console.SetCursorPosition(30, 2 * i);
                                    Console.WriteLine($"ID:{i} ");
                                    Console.SetCursorPosition(35, 2 * i);
                                    lista[i].Wyswietl();
                                }
                                Console.WriteLine("Podaj ID mężczyzny: ");
                                
                                choose = int.Parse(Console.ReadLine());

                                if (choose <= (lista.Count - 1) && choose >= 0)
                                {
                                    Adam = lista[choose];
                                }
                                else
                                    break;


                                Console.WriteLine("Podaj ID kobiety: ");
                                choose = int.Parse(Console.ReadLine());

                                if (choose <= (lista.Count - 1) && choose >= 0)
                                {
                                    Ewa = lista[choose];
                                }


                                if (Adam.Plec != Ewa.Plec && Adam is Dorosly && Ewa is Dorosly)
                                {
                                    Milosc Platoniczna = new Milosc(Adam, Ewa);
                                    lista.Add(Platoniczna.Poród());
                                    Console.WriteLine($"Płeć dzieciaczka to: {lista[lista.Count - 1].Plec}, Podaj imię dzieciaczka: ");
                                    imie = Console.ReadLine();

                                    lista[lista.Count - 1].Dajimie(imie);
                                }
                                else
                                {
                                    Console.WriteLine("Chłop z chłopem lub baba z babą lub dziecko nie mogą mieć dziecka");
                                    System.Threading.Thread.Sleep(3000);
                                }
                                break;

                            case 1:

                                for (int i = 0; i < lista.Count; i++)
                                {
                                    Console.SetCursorPosition(30, 2 * i);
                                    Console.WriteLine($"ID:{i} ");
                                    Console.SetCursorPosition(35, 2 * i);
                                    lista[i].Wyswietl();
                                }

                                Console.WriteLine("Ile osób bierze udział w rozmowie? Wybierz od 2-4 osób. ");
                                ileludzi = int.Parse(Console.ReadLine());
                                if (ileludzi >= 2 && ileludzi <= 4)
                                {
                                    switch (ileludzi)
                                    {
                                        case 2:
                                            Console.WriteLine("Osoba 1: ");
                                            int k1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 2: ");
                                            int k2 = int.Parse(Console.ReadLine());
                                            if (k2 >= 0 && k2 <= lista.Count && k1 >= 0 && k1 <= lista.Count && k1 != k2)
                                            {
                                                Rozmowa rozmowa = new Rozmowa(lista[k1], lista[k2]);
                                                Rozmowa TalkyTalk = rozmowa;
                                                TalkyTalk.WalkieTalkie();
                                            }

                                            break;
                                        case 3:
                                            Console.WriteLine("Osoba 1: ");
                                            int q1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 2: ");
                                            int q2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 3: ");
                                            int q3 = int.Parse(Console.ReadLine());
                                            if (q2 >= 0 && q2 <= lista.Count && q1 >= 0 && q1 <= lista.Count && q3 >= 0 && q3 <= lista.Count && q1 != q3 && q2 != q3 && q1 != q2)
                                            {
                                                Rozmowa rozmowa = new Rozmowa(lista[q1], lista[q2], lista[q3]);
                                                Rozmowa TalkyTalk = rozmowa;
                                                TalkyTalk.WalkieTalkie();
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine("Osoba 1: ");
                                            int r1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 2: ");
                                            int r2 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 3: ");
                                            int r3 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Osoba 4: ");
                                            int r4 = int.Parse(Console.ReadLine());
                                            if (r2 >= 0 && r2 <= lista.Count && r1 >= 0 && r1 <= lista.Count && r3 >= 0 && r3 <= lista.Count && r4 >= 0 && r4 <= lista.Count && r1 != r3 && r2 != r4 && r2 != r3 && r1 != r4)
                                            {
                                                Rozmowa rozmowa = new Rozmowa(lista[r1], lista[r2], lista[r3], lista[r4]);
                                                Rozmowa TalkyTalk = rozmowa;
                                                TalkyTalk.WalkieTalkie();
                                            }
                                            break;
                                    }
                                }

                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.SetCursorPosition(30, 2 * i);
                            Console.WriteLine($"ID:{i} ");
                            Console.SetCursorPosition(35, 2 * i);
                            lista[i].Wyswietl();
                        }
                        Console.WriteLine("Podaj ID Dorosłego: ");
                        ID = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (ID <= (lista.Count - 1) && ID >= 0)
                        {
                            WyborPraca = PracaMenu.Wyswietl();
                            switch (WyborPraca)
                            {
                                case 0:

                                    if (lista[ID].Wiek>18)
                                        lista[ID].Praca = new Prawnik();
                                    else
                                        Console.WriteLine("Nie możesz dać dziecku pracy.");
                                    System.Threading.Thread.Sleep(2000);

                                    break;
                                case 1:
                                    if (lista[ID].Wiek>18)
                                        lista[ID].Praca = new Programista();
                                    else
                                        Console.WriteLine("Nie możesz dać dziecku pracy.");
                                    System.Threading.Thread.Sleep(2000);

                                    break;
                            }
                        }
                        else
                            break;

                        break;
                    case 4:
                        Console.Clear();
                        Console.SetCursorPosition(30, 0);
                        Console.WriteLine("Kuchnia: 20000$  Łazienka: 30000$,  Salon: 50000$");
                        WyborDom = DomMenu.Wyswietl();
                        switch(WyborDom)
                        {
                            case 0:
                                Console.Clear();
                                if (Dom.Łazienka != null)
                                {
                                    Console.SetCursorPosition(6, 5);
                                    Console.WriteLine(" _____");
                                    Console.SetCursorPosition(6, 6);
                                    Console.WriteLine("/    |");
                                    Console.SetCursorPosition(6, 7);
                                    Console.WriteLine("| #  |");
                                    Console.SetCursorPosition(6, 8);
                                    Console.WriteLine("|    |");

                                }
                                if (Dom.Salon != null)
                                {
                                    Console.SetCursorPosition(12, 3);
                                    Console.WriteLine(" __ii");
                                    Console.SetCursorPosition(12, 4);
                                    Console.WriteLine(@"/    \");
                                    Console.SetCursorPosition(12, 5);
                                    Console.WriteLine("|   o|");
                                    Console.SetCursorPosition(12, 6);
                                    Console.WriteLine("| O  |");
                                    Console.SetCursorPosition(12, 7);
                                    Console.WriteLine("| __ |");
                                    Console.SetCursorPosition(12, 8);
                                    Console.WriteLine("| || |");

                                }
                                if (Dom.Kuchnia != null)
                                {
                                    Console.SetCursorPosition(18, 5);
                                    Console.WriteLine("______");
                                    Console.SetCursorPosition(18, 6);
                                    Console.WriteLine("| __ |");
                                    Console.SetCursorPosition(18, 7);
                                    Console.WriteLine("| [] |");
                                    Console.SetCursorPosition(18, 8);
                                    Console.WriteLine("|    |");

                                }


                                Console.ReadKey();

                                break;
                            case 1:
                                pieniadze = Dom.ZróbKuchnie(pieniadze);
                                System.Threading.Thread.Sleep(2000);
                                
                                break;
                            case 2:
                                pieniadze = Dom.ZróbŁazienkę(pieniadze);
                                System.Threading.Thread.Sleep(2000);

                                break;
                            case 3:
                                pieniadze = Dom.ZróbSalon(pieniadze);
                                System.Threading.Thread.Sleep(2000);

                                break;
                        }    

                        break;
                }

            } while (!(wyborSter == 5 || wyborSter == -1));



        }
    }
}
