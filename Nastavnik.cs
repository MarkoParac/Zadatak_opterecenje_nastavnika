using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opterecenje_nastavnika
{
    class Nastavnik
    {
        public string ImePrezime { get; set; }
        public int Opterecenje { get; set; }

        public Nastavnik(string naziv, int opterecenje)
        {
            ImePrezime = naziv;
            Opterecenje = opterecenje;
        }


    }
}
