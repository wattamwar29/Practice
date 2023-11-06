using MovieApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class DetailController:ControllerBase
    {
        MovieContext context= new MovieContext();
        [HttpGet]
        [Route("DisplayMovieDetailS/{id}")]
        public IActionResult Get(int id)
        {
            var data = from d in context.Details where d.MovieId=id select new{
                Artist=d.Actor,Role=d.Role,MovieName=d.MovieName,Year=d.Movie.YearRelease
            };
            return Ok(data);
        }
        [HttpGet]
        [Route("ListDetail")]
        public IActionResult Get()
        {
            
        }
    }
}