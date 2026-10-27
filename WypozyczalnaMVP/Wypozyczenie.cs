using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalnaMVP
{
    public class Wypozyczenie
    {
        public int Id { get; set; }
        public int idSprzetu { get; set; }
        public string osoba { get; set; }
        public string Opis { get; set; } = string.Empty;
        public DateTime data { get; set; }
        public bool Aktywne { get; private set; } = true;
        public Wypozyczenie(int id, int idSprzetu, string osoba)
        {
            this.Id = id;
            this.idSprzetu = idSprzetu;
            this.osoba = osoba;
            this.data = DateTime.Now;
        }
        public void Zakoncz()
        {
            Aktywne = false;
        }
    }
}
