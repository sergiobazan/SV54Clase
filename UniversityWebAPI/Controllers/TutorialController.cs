using Microsoft.AspNetCore.Mvc;
using UniversityWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private readonly List<Tutorial> tutorials = new List<Tutorial>
        {
            new Tutorial{Id= 1, Title=".NET tutorial", Description="Description", Year=2022}
        };

        // GET: api/<Tutorial7Controller>
        [HttpGet]
        public IEnumerable<Tutorial> Get()
        {
            return tutorials;
        }

        // GET api/<Tutorial7Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Tutorial7Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Tutorial7Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Tutorial7Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
