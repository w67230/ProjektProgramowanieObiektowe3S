using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekaKlas.Lekarze;
using BibliotekaKlas.Pacjenci;

namespace BibliotekaKlas.Wizyty
{
    public static class WizytaHelper
    {

        public static Lekarz getLekarz(int id)
        {
            List<Lekarz> list = FileHelper<Lekarz>.getListaFromFile(DzialaniaLekarz.filePath);
            foreach (Lekarz lekarz in list)
            {
                if (lekarz.getId() == id)
                {
                    return lekarz;
                }
            }
            return new Lekarz(id, "nieznane", "nieznane");
        }

        public static Pacjent getPacjent(string id)
        {
            List<Pacjent> list = FileHelper<Pacjent>.getListaFromFile(DzialaniaPacjent.filePath);
            foreach (Pacjent pacjent in list)
            {
                if (pacjent.getId() == id)
                {
                    return pacjent;
                }
            }
            return new Pacjent(id, "nieznane", "nieznane");
        }

        public static List<Wizyta> getWizytaWithPesel(Dzialania<Wizyta, DateTime> dzialania, string pesel)
        {
            List<Wizyta> list = dzialania.GetAll();
            List<Wizyta> wynik = new List<Wizyta>();
            foreach (Wizyta wizyta in list)
            {
                if(wizyta.pacjent.getId() == pesel)
                {
                    wynik.Add(wizyta);
                }
            }
            return wynik;
        }

        public static List<Wizyta> getWizytaWithId(Dzialania<Wizyta, DateTime> dzialania, int id)
        {
            List<Wizyta> list = dzialania.GetAll();
            List<Wizyta> wynik = new List<Wizyta>();
            foreach (Wizyta wizyta in list)
            {
                if (wizyta.lekarz.getId() == id)
                {
                    wynik.Add(wizyta);
                }
            }
            return wynik;
        }

        public static void DeleteAllWithPesel(Dzialania<Wizyta, DateTime> dzialania, string pesel)
        {
            List<Wizyta> list = dzialania.GetAll();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].pacjent.getId() == pesel)
                {
                    list.RemoveAt(i);
                }
            }
            dzialania.WriteFile(list);
        }

        public static void DeleteAllWithId(Dzialania<Wizyta, DateTime> dzialania, int id)
        {
            List<Wizyta> list = dzialania.GetAll();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].lekarz.getId() == id)
                {
                    list.RemoveAt(i);
                }
            }
            dzialania.WriteFile(list);
        }

        public static void DeleteWithPesel(Dzialania<Wizyta, DateTime> dzialania, DateTime dateTime, string pesel)
        {
            List<Wizyta> list = dzialania.GetAll();
            foreach (Wizyta wizyta in list)
            {
                if(wizyta.getId() == dateTime && wizyta.pacjent.getId() == pesel)
                {
                    list.Remove(wizyta);
                    break;
                }
            }
            dzialania.WriteFile(list);
        }

        public static void DeleteWithId(Dzialania<Wizyta, DateTime> dzialania, DateTime dateTime, int id)
        {
            List<Wizyta> list = dzialania.GetAll();
            foreach (Wizyta wizyta in list)
            {
                if (wizyta.getId() == dateTime && wizyta.lekarz.getId() == id)
                {
                    list.Remove(wizyta);
                    break;
                }
            }
            dzialania.WriteFile(list);
        }
    }
}
