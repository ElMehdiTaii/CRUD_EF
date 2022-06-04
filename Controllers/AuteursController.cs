using App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Livres.Controllers
{
    public class AuteursController : Controller
    {
        private readonly dbContext _context;
        public AuteursController(dbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuteursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuteursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuteursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuteursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
