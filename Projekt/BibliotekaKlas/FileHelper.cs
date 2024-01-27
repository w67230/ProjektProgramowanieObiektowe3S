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
    public static class FileHelper<U>
    {
        public static List<U> getListaFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (content != null && content != "")
                {
                    return JsonSerializer.Deserialize<List<U>>(content);
                }
            }
            return new List<U>();
        }

        /*

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
        */
    }
}
