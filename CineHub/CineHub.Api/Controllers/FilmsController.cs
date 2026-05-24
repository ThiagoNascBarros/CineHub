using CineHub.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private List<Film> films = [];

        [HttpGet]
        public List<Film> Get()
        {
            return films;
        }

        [HttpPost]
        public void Post([FromBody] Film film)
        {
            films.Add(film);
        }

    }
}
