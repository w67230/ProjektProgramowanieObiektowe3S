using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BibliotekaKlas.Lekarze
{
    public class DzialaniaLekarz : Dzialania<Lekarz, int>
    {
        private readonly string filePath = "lekarze.json";
        public void Create(Lekarz t)
        {
            List<Lekarz> list = GetAll();
            list.Add(t);
            WriteFile(list);
        }

        public void Delete(int id)
        {
            List<Lekarz> list = GetAll();
            foreach (Lekarz lekarz in list)
            {
                if (lekarz.getId() == id)
                {
                    list.Remove(lekarz);
                    break;
                }
            }
            WriteFile(list);
        }

        public Lekarz Get(int id)
        {
            foreach (Lekarz lekarz in GetAll())
            {
                if (lekarz.getId() == id)
                {
                    return lekarz;
                }
            }
            return new Lekarz(id, null, null);
        }

        public List<Lekarz> GetAll()
        {
            return ReadFile();
        }

        public void Update(Lekarz t)
        {
            List<Lekarz> list = GetAll();
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

        public List<Lekarz> ReadFile()
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (content != null && content != "")
                {
                    return JsonSerializer.Deserialize<List<Lekarz>>(content);
                }
            }
            return new List<Lekarz>();
        }

        public void WriteFile(List<Lekarz> list)
        {
            string content = JsonSerializer.Serialize(list);
            File.WriteAllText(filePath, content);
        }
    }
}
