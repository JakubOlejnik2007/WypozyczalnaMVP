using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalnaMVP
{
    public class Sprzet
    {
        public int id { get; set; }
        public string nazwa { get; set; }
        public string Opis { get; set; } = string.Empty;
        public bool czyDostepne { get; set; } //false - nie, true - tak
        public Sprzet(int id, string nazwa)
        {
            this.id = id;
            this.nazwa = nazwa;
            czyDostepne = true;
        }
    }
}
