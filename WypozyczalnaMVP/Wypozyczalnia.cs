using System;
namespace WypozyczalnaMVP
{
    class Wypozyczalnia
    {
        private readonly List<Sprzet> sprzety = new()
    {
            new(1, "Laptop"), new(2, "Projektor"),
            new(3, "Aparat"), new(4, "Mikrofon")
        };

        private readonly List<Wypozyczenie> historia = new();
        private int nastepneId = 1;

        public bool CzyDostepny(int id) =>
            sprzety.Any(s => s.id == id) &&
            !historia.Any(w => w.idSprzetu == id && w.Aktywne);

        public Wypozyczenie Wypozycz(int id, string osoba)
        {
            if (string.IsNullOrWhiteSpace(osoba))
                throw new ArgumentException("Podaj imię i nazwisko.");

            if (!CzyDostepny(id))
                throw new InvalidOperationException("Sprzęt jest niedostępny lub nie istnieje.");

            var wyp = new Wypozyczenie(nastepneId++, id, osoba.Trim());
            historia.Add(wyp);
            return wyp;
        }

        public void Zwroc(int id)
        {
            var wyp = historia.FirstOrDefault(w => w.Id == id)
                ?? throw new ArgumentException("Nie znaleziono wypożyczenia.");

            wyp.Zakoncz();
        }

        public void ListaSprzetow()
        {
            foreach (var s in sprzety)
                Console.WriteLine($"{s.nazwa} \t| " +
                    (CzyDostepny(s.id) ? "Dostępny" : "Wypożyczony") + $"\t| {s.Opis}");
        }

        public void ListaWypozyczen()
        {
            if (historia.Count == 0)
                Console.WriteLine("Brak wypożyczeń.");

            foreach (var w in historia)
                Console.WriteLine(w.Opis);
        }
    }
}
