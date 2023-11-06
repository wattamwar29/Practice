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
            var data = from d in context.Details where d.MovieId==id select new{
                Artist=d.Actor,Role=d.Role,MovieName=d.Movie.Name,Year=d.Movie.YearRelease
            };
            return Ok(data);
        }
        [HttpGet]
        [Route("ListDetail")]
        public IActionResult Get()
        {
            var data=from d in context.Details select new{MovieName=d.Movie.Name,Artist=d.Actor};
            return Ok(data);
        }
        [HttpGet]
    [Route("ListDetails/{id}")]
    public IActionResult Get(int? id)
    {
       if(id==null)
        {
            return BadRequest("Id cannot be null");
        }
            var data = (from d in context.Details where d.MovieId ==id select d).FirstOrDefault();
            if(id==null)
            {
                return NotFound($"Detail {id} not found");
            }
            return Ok(data);
        }
         [HttpPost]
        [Route("AddDetails")]
        public IActionResult Post([FromBody] Detail detail)
        {
            if(ModelState.IsValid){
                try{
                    context.Details.Add(detail);
                    context.SaveChanges();
                }
                catch(System.Exception ex){
                    return BadRequest(ex.InnerException.Message);
                }
            }
            return Created("Record Added",detail);
        }
 
        [HttpPut]
        [Route("EditDetails/id")]
        public IActionResult Put(int id, Detail detail)
        {
            if(ModelState.IsValid)
            {Detail detail1 = context.Details.Find(id);
            detail1.DetailId = detail.DetailId;
            detail1.Actor=detail.Actor;
            detail1.MovieId=detail.MovieId;
            detail1.Gender=detail.Gender;
            detail1.Role=detail.Gender;
            context.SaveChanges();
            return Ok();
            }  
           
            return BadRequest("Unable to Edit record");
        }
        // [HttpDelete]
        // [Route("DeleteMovies/id")]
        // public IActionResult Delete(int id)
        // {
        //     try{
        //             var movie = context.Movies.Where(m=>m.DetailId==id);
        //             if(movie.Count()!=0){
        //                 throw new Exception("Cannot Delete Movie");
        //             }
        //             var data = context.Details.Find(id);
        //             context.Details.Remove(data);
        //             return Ok();
        //         }
        //         catch(System.Exception ex){
        //             return BadRequest(ex.Message);
        //         }
        // }
 
    }
}
