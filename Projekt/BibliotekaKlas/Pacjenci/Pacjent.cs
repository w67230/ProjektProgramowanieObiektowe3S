using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlas.Pacjenci
{
    public class Pacjent : PosiadaID<string>
    {
        public string pesel { get; set; }
        public string imie { get; }
        public string nazwisko { get; }

        public Pacjent(string pesel, string imie, string nazwisko)
        {
            this.pesel = pesel;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public string getId()
        {
            return pesel;
        }

        public string getImie()
        {
            return imie;
        }

        public string getNazwisko()
        {
            return nazwisko;
        }

        public void setId(string id)
        {
            pesel = id;
        }
    }
}
