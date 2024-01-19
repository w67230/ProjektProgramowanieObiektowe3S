using Microsoft.AspNetCore.Mvc;
using BibliotekaKlas;
using BibliotekaKlas.Pacjenci;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacjentController : ControllerBase
    {

        private readonly Dzialania<Pacjent, string> dzialania;

        public PacjentController(Dzialania<Pacjent, string> dzialania)
        {
            this.dzialania = dzialania;
        }

        [HttpGet("get")]
        public Pacjent Get(string id)
        {
            return this.dzialania.Get(id);
        }

        [HttpGet("getAll")]
        public List<Pacjent> GetAll()
        {
            return this.dzialania.GetAll();
        }

        [HttpPost("create")]
        public void Create(Pacjent pacjent)
        {
            this.dzialania.Create(pacjent);
        }

        [HttpPut("update")]
        public void Update(Pacjent pacjent)
        {
            this.dzialania.Update(pacjent);
        }

        [HttpDelete("delete")]
        public void Delete(string id)
        {
            this.dzialania.Delete(id);
        }
    }
}
