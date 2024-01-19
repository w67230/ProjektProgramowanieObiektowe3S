using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BibliotekaKlas.Pacjenci
{
    public class DzialaniaPacjent : Dzialania<Pacjent, string>
    {
        public static readonly string filePath = "pacjenci.json";
        public void Create(Pacjent t)
        {
            List<Pacjent> list = GetAll();
            list.Add(t);
            WriteFile(list);
        }

        public void Delete(string id)
        {
            List<Pacjent> list = GetAll();
            foreach (Pacjent pacjent in list)
            {
                if (pacjent.getId() == id)
                {
                    list.Remove(pacjent);
                    break;
                }
            }
            WriteFile(list);
        }

        public Pacjent Get(string id)
        {
            foreach (Pacjent pacjent in GetAll())
            {
                if (pacjent.getId() == id)
                {
                    return pacjent;
                }
            }
            return new Pacjent(id, null, null);
        }

        public List<Pacjent> GetAll()
        {
            return FileHelper.getListaPacjentowFromFile();
        }

        public void Update(Pacjent t)
        {
            List<Pacjent> list = GetAll();
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


        public void WriteFile(List<Pacjent> list)
        {
            string content = JsonSerializer.Serialize(list);
            File.WriteAllText(filePath, content);
        }
    }
}
