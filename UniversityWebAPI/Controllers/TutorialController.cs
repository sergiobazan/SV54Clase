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
        public Tutorial Get(int id)
        {
            return tutorials.Find(x => x.Id == id);
        }

        // POST api/<Tutorial7Controller>
        [HttpPost]
        public List<Tutorial> Post([FromBody] Tutorial value)
        {
            tutorials.Add(value);
            return tutorials;
        }

        // PUT api/<Tutorial7Controller>/5
        [HttpPut("{id}")]
        public List<Tutorial> Put(int id, [FromBody] Tutorial value)
        {
            var tutorialFound = tutorials.Find(x => x.Id == id);
            tutorialFound.Title = value.Title;
            tutorialFound.Year = value.Year;
            tutorialFound.Description = value.Description;
            return tutorials;
        }

        // DELETE api/<Tutorial7Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var tutorialFound = tutorials.Find(x => x.Id == id);
            tutorials.Remove(tutorialFound);
            return;
        }
    }
}
