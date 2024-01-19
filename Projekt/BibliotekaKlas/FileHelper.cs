using BibliotekaKlas.Lekarze;
using BibliotekaKlas.Pacjenci;
using BibliotekaKlas.Wizyty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotekaKlas
{
    public static class FileHelper
    {



        public static List<Lekarz> getListaLekarzyFromFile()
        {
            if (File.Exists(DzialaniaLekarz.filePath))
            {
                string content = File.ReadAllText(DzialaniaLekarz.filePath);
                if (content != null && content != "")
                {
                    return JsonSerializer.Deserialize<List<Lekarz>>(content);
                }
            }
            return new List<Lekarz>();
        }

        public static List<Pacjent> getListaPacjentowFromFile()
        {
            if (File.Exists(DzialaniaPacjent.filePath))
            {
                string content = File.ReadAllText(DzialaniaPacjent.filePath);
                if (content != null && content != "")
                {
                    return JsonSerializer.Deserialize<List<Pacjent>>(content);
                }
            }
            return new List<Pacjent>();
        }

        public static List<Wizyta> getListaWizytFromFile()
        {
            if (File.Exists(DzialaniaWizyta.filePath))
            {
                string content = File.ReadAllText(DzialaniaWizyta.filePath);
                if (content != null && content != "")
                {
                    return JsonSerializer.Deserialize<List<Wizyta>>(content);
                }
            }
            return new List<Wizyta>();
        }
    }
}
