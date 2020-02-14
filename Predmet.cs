using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opterecenje_nastavnika
{
    class Predmet
    {
        public string Naziv { get; set; }
        public int BrojSati { get; set; }
        public string Nastavnik { get; set; }

        public Predmet(string naziv, int brojsati, string nastavnik)
        {
            Naziv = naziv;
            BrojSati = brojsati;
            Nastavnik = nastavnik;
        }
    }
}
