namespace WypozyczalnaMVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wypozyczalnia wypozyczalnia = new Wypozyczalnia();


            Console.WriteLine("Witaj w naszej wypożyczalni");
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("[1] Wypożycz");
            Console.WriteLine("[2] Zwróć");
            Console.WriteLine("[3] Sprawdź dostępność sprzętu");
            Console.WriteLine("[4] Wyświetl wszystki sprzęt");
            Console.WriteLine("[5] Wyświetl historię wypożyczeń");
            Console.WriteLine("[6] Wyjście");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int wybor))
                {
                    Console.WriteLine("Wpisz poprawny numer opcji.");
                    continue;
                }
                int exit = 0;
                int idSprzetu = 0;
                string nazwaOsoby;

                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj numer sprzętu, który chcesz wypożyczyć:");

                        if (!int.TryParse(Console.ReadLine(), out idSprzetu))
                        {
                            Console.WriteLine("Numer sprzętu musi być liczbą całkowitą.");
                            continue;
                        }
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj imię i nazwisko osoby wypożyczającej:");
                        nazwaOsoby = Console.ReadLine();
                        wypozyczalnia.Wypozycz(idSprzetu, nazwaOsoby);
                        break;
                    case 2:
                        Console.WriteLine("Podaj numer sprzętu, który chcesz zwrócić:");
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        wypozyczalnia.Zwroc(idSprzetu);
                        break;
                    case 3:
                        Console.WriteLine("Podaj numer sprzętu, którego dostępność chcesz sprawdzić");
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        wypozyczalnia.ListaSprzetow();
                        break;
                    case 5:
                        wypozyczalnia.ListaWypozyczen();
                        break;
                    case 6:
                        Console.WriteLine("Dziękujemy za skorzystanie z naszej wypożyczalni!");
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }

                if (exit == 1)
                {
                    break;
                }
            }
        }
    }
}

