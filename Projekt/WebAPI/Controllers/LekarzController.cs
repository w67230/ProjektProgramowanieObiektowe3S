﻿using Microsoft.AspNetCore.Mvc;
using BibliotekaKlas;
using BibliotekaKlas.Lekarze;


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

        [HttpGet("get")]
        public Lekarz Get(int id)
        {
            return this.dzialania.Get(id);
        }

        
        [HttpGet("getAll")]
        public List<Lekarz> GetAll()
        {
            return this.dzialania.GetAll();
        }
        

        [HttpPost("create")]
        public void Create(Lekarz lekarz)
        {
            this.dzialania.Create(lekarz);
        }

        [HttpPut("update")]
        public void Update(Lekarz lekarz)
        {
            this.dzialania.Update(lekarz);
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            this.dzialania.Delete(id);
        }
    }
}
