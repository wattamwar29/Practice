using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MovieApp.Models
{
    public class Movie
    {
        
        public int Id{get;set;}
        [Required]
        public string Name{get;set;}
        public int YearRelease{get;set;}
        public int Rating{get;set;}
        public ICollection<Detail> Details{get;set;}

    }
}