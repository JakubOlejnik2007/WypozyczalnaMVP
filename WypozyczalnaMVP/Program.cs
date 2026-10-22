namespace WypozyczalnaMVP
{
    public class Sprzet
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public bool czyDostepne { get; set; } //false - nie, true - tak
        public Sprzet(int id, string nazwa)
        {
            id = this.id;
            nazwa = this.nazwa;
            czyDostepne = true;
        }
    }

    public class Wypozyczenie
    {
        public int id { get; set; }
        public string osoba { get; set; }
        public DateTime data { get; set; }
    }
    public class Wypozyczalnia
    {
        public List<string> historia;

        public void wypozycz(Sprzet sprzet, Wypozyczenie wypozyczenie)
        {
            if (sprzet.czyDostepne == true)
            {
                string akcja = wypozyczenie.id + ".) Wypożyczenie: " + sprzet.nazwa + " przez: " + wypozyczenie.osoba + " | " + wypozyczenie.data;
                sprzet.czyDostepne = false;
                //TODO: stwórz obiekt wypozyczenie i dodaj do historii
            }
            else
            {
                //komunikat o tym że ten sprzęt nie jest dostępny
            }

        }
        public void zwroc(Sprzet sprzet, Wypozyczenie wypozyczenie)
        {
            if (sprzet.czyDostepne == false)
            {
                string akcja = wypozyczenie.id + ".) Zwrot: " + sprzet.nazwa + " przez: " + wypozyczenie.osoba + " | " + wypozyczenie.data;
                sprzet.czyDostepne = true;
                //TODO: stwórz obiekt wypozyczenie i dodaj do historii
            }
            else
            {
                //komunikat o tym że ten sprzęt został zwrócony
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
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
                int wybor = Convert.ToInt32(Console.ReadLine());
                int exit = 0;
                int idSprzetu = 0;
                string nazwaOsoby;

                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj numer sprzętu, który chcesz wypożyczyć:");
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj imię i nazwisko osoby wypożyczającej:");
                        nazwaOsoby = Console.ReadLine();
                        Wypozycz(idSprzetu, nazwaOsoby);
                        break;
                    case 2:
                        Console.WriteLine("Podaj numer sprzętu, który chcesz zwrócić:");
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        Zwroc(idSprzetu);
                        break;
                    case 3:
                        Console.WriteLine("Podaj numer sprzętu, którego dostępność chcesz sprawdzić");
                        idSprzetu = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        ListaSprzetow();
                        break;
                    case 5:
                        ListaWypozyczen();
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

