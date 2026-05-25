using CineHub.Api.Data;
using CineHub.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CineHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {

        private readonly DataContext _context;

        public FilmsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var film = _context.Films.FirstOrDefault(film => film.Id == id);
            
            if (film == null) return NotFound();

            return Ok(film);
        }

        [HttpGet]
        public IEnumerable<Film> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _context.Films.Skip(skip).Take(take);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Film film)
        {
            var entity = _context.Films.Add(film);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { Id = entity.Entity.Id}, film);
        }

    }
}
