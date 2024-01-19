using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BibliotekaKlas.Lekarze;
using BibliotekaKlas.Pacjenci;
using System.Text.Json.Serialization;

namespace BibliotekaKlas.Wizyty
{
    public class Wizyta : PosiadaID<DateTime>
    {
        public DateTime dataWizyty { get; set; }
        public Lekarz lekarz { get; set; }
        public Pacjent pacjent { get; set; }

        [JsonConstructor]
        public Wizyta(DateTime dataWizyty, Lekarz lekarz, Pacjent pacjent)
        {
            this.dataWizyty = dataWizyty;
            this.lekarz = lekarz;
            this.pacjent = pacjent;
        }

        public Wizyta(DateTime dataWizyty, string peselPacjenta, int idLekarza)
        {
            this.dataWizyty = dataWizyty;
            this.pacjent = WizytaHelper.getPacjent(peselPacjenta);
            this.lekarz = WizytaHelper.getLekarz(idLekarza);
        }

        public DateTime getId()
        {
            return this.dataWizyty;
        }

        public void setId(DateTime id)
        {
            this.dataWizyty = id;
        }
    }
}
