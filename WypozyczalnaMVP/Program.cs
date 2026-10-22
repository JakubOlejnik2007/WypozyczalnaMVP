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
        public Wypozyczenie(int id, string osoba)
        {
            id = this.id;
            osoba = this.osoba;
            data = DateTime.Now;
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
            int sprzetId = 0;
            int wypozyczenieId = 0;
        }
    }
}

