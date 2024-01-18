using Microsoft.AspNetCore.Mvc;
using BibliotekaKlas;
using BibliotekaKlas.Lekarze;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LekarzController : ControllerBase
    {

        private readonly Dzialania<Lekarz, int> dzialania;

        public LekarzController(Dzialania<Lekarz, int> dzialania)
        {
            this.dzialania = dzialania;
        }

        // GET: api/<LekarzController>
        [HttpGet]
        public Lekarz Get(int id)
        {
            return this.dzialania.Get(id);
        }

        /*
        // GET api/<LekarzController>/5
        [HttpGet]
        public List<Lekarz> GetAll()
        {
            return this.dzialania.GetAll();
        }
        */

        // POST api/<LekarzController>
        [HttpPost]
        public void Create(Lekarz lekarz)
        {
            this.dzialania.Create(lekarz);
        }

        // PUT api/<LekarzController>/5
        [HttpPut]
        public void Update(Lekarz lekarz)
        {
            this.dzialania.Update(lekarz);
        }

        // DELETE api/<LekarzController>/5
        [HttpDelete]
        public void Delete(int id)
        {
            this.dzialania.Delete(id);
        }
    }
}
