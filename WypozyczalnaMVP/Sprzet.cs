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
        public bool czyDostepne { get; set; } //false - nie, true - tak
        public Sprzet(int id, string nazwa)
        {
            id = this.id;
            nazwa = this.nazwa;
            czyDostepne = true;
        }
    }
}
