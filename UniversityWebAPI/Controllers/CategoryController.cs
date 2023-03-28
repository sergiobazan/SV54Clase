using Microsoft.AspNetCore.Mvc;
using UniversityWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly List<Category> categories = new List<Category>
        {
            new Category{Id= 1,Name="IT", Description="Tecnologia", Quantity=1}
        };

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return categories.Find(x => x.Id == id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public List<Category> Post([FromBody] Category value)
        {
            categories.Add(value);
            return categories;
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public List<Category> Put(int id, [FromBody] Category value)
        {
            var cateogryFound = categories.Find(x => x.Id == id);
            cateogryFound.Description = value.Description;
            cateogryFound.Quantity = value.Quantity;
            cateogryFound.Name = value.Name;
            return categories;
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cateogryFound = categories.Find(x => x.Id == id);
            categories.Remove(cateogryFound);
            return;
        }
    }
}
