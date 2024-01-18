using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlas.Lekarze
{
    public class Lekarz : Osoba<int>
    {
        public int id { get; set; }
        public string imie { get; }
        public string nazwisko { get; }

        public Lekarz(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public int getId()
        {
            return id;
        }

        public string getImie()
        {
            return imie;
        }

        public string getNazwisko()
        {
            return nazwisko;
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
