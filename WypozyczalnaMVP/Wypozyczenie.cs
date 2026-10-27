using System;

namespace WypozyczalnaMVP
{
    public class Wypozyczenie
    {
        public int Id { get; set; }
        public int idSprzetu { get; set; }
        public string osoba { get; set; }
        public string Opis { get; set; }
        public DateTime data { get; set; }
        public bool Aktywne { get; private set; } = true;

        public Wypozyczenie(int id, int idSprzetu, string osoba)
        {
            Id = id;
            this.idSprzetu = idSprzetu;
            this.osoba = osoba;
            data = DateTime.Now;
            Aktywne = true;
        }

        public void Zakoncz()
        {
            if (!Aktywne)
            {
                throw new InvalidOperationException("To wypożyczenie zostało już zakończone.");
            }

            Aktywne = false;
        }

        public string Opis()
        {
            return $"ID wypożyczenia: {Id} | " + $"ID sprzętu: {idSprzetu} | " + $"Osoba: {osoba} | " + $"Data: {data} | " + $"Status: {(Aktywne ? "Aktywne" : "Zakończone")}";
        }
    }
}
