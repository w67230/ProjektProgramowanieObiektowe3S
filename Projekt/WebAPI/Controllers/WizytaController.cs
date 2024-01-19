using Microsoft.AspNetCore.Mvc;
using BibliotekaKlas;
using BibliotekaKlas.Wizyty;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WizytaController : ControllerBase
    {

        private readonly Dzialania<Wizyta, DateTime> dzialania;

        public WizytaController(Dzialania<Wizyta, DateTime> dzialania)
        {
            this.dzialania = dzialania;
        }

        [HttpGet("getAll")]
        public List<Wizyta> GetAll()
        {
            return this.dzialania.GetAll();
        }

        [HttpGet("getFirst")]
        public Wizyta Get(DateTime dateTime)
        {
            return this.dzialania.Get(dateTime);
        }

        [HttpGet("getWizytyPacjenta")]
        public List<Wizyta> GetWithPesel(string pesel)
        {
            return WizytaHelper.getWizytaWithPesel(this.dzialania, pesel);
        }

        [HttpGet("getWizytyLekarza")]
        public List<Wizyta> GetWithId(int id)
        {
            return WizytaHelper.getWizytaWithId(this.dzialania, id);
        }

        [HttpPost("create")]
        public void Create(DateTime dataWizyty, string peselPacjenta, int idLekarza)
        {
            this.dzialania.Create(new Wizyta(dataWizyty, peselPacjenta, idLekarza));
        }

        [HttpPut("update")]
        public void Update(DateTime dateTime, string peselPacjenta, int idLekarza)
        {
            this.dzialania.Update(new Wizyta(dateTime, peselPacjenta, idLekarza));
        }

        [HttpDelete("deleteFirst")]
        public void Delete(DateTime id)
        {
            this.dzialania.Delete(id);
        }

        [HttpDelete("deleteWithPesel")]
        public void DeleteWithPesel(DateTime dateTime, string pesel)
        {
            WizytaHelper.DeleteWithPesel(this.dzialania, dateTime, pesel);
        }

        [HttpDelete("deleteWithId")]
        public void DeleteWithId(DateTime dateTime, int id)
        {
            WizytaHelper.DeleteWithId(this.dzialania, dateTime, id);
        }

        [HttpDelete("deleteAllWithPesel")]
        public void DeleteAllWithPesel(string pesel)
        {
            WizytaHelper.DeleteAllWithPesel(this.dzialania, pesel);
        }

        [HttpDelete("deleteAllWithId")]
        public void DeleteAllWithId(int id)
        {
            WizytaHelper.DeleteAllWithId(this.dzialania, id);
        }
    }
}
