using MovieApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
namespace MovieApp.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class MovieController:ControllerBase
    {
        MovieContext context=new MovieContext();
        [HttpGet]
        [Route("ListMovies")]
        public IActionResult Get()
        {
            
        }
    }
}