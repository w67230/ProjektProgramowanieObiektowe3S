using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekaKlas.Lekarze;
using BibliotekaKlas.Pacjenci;

namespace BibliotekaKlas.Wizyty
{
    public class Wizyta
    {
        public Lekarz lekarz { get; set; }
        public Pacjent pacjent { get; set; }
        public DateTime dataWizyty { get; set; }

    }
}
