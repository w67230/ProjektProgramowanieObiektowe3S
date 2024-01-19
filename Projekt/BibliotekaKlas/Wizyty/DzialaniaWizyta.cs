using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BibliotekaKlas.Wizyty
{
    public class DzialaniaWizyta : Dzialania<Wizyta, DateTime>
    {
        public static readonly string filePath = "wizyty.json";
        public void Create(Wizyta t)
        {
            List<Wizyta> list = GetAll();
            list.Add(t);
            WriteFile(list);
        }

        public void Delete(DateTime id)
        {
            List<Wizyta> list = GetAll();
            foreach (Wizyta wizyta in list)
            {
                if (wizyta.getId() == id)
                {
                    list.Remove(wizyta);
                    break;
                }
            }
            WriteFile(list);
        }

        public Wizyta Get(DateTime id)
        {
            foreach (Wizyta wizyta in GetAll())
            {
                if (wizyta.getId() == id)
                {
                    return wizyta;
                }
            }
            return new Wizyta(DateTime.Now, "nieznany", -1);
        }

        public List<Wizyta> GetAll()
        {
            return FileHelper.getListaWizytFromFile();
        }

        public void Update(Wizyta t)
        {
            List<Wizyta> list = GetAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getId() == t.getId())
                {
                    list[i] = t;
                    break;
                }
            }
            WriteFile(list);
        }


        public void WriteFile(List<Wizyta> list)
        {
            string content = JsonSerializer.Serialize(list);
            File.WriteAllText(filePath, content);
        }
    }
}
