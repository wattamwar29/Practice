using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MovieApp.Models
{
    public class Detail
    {
        [Key]
        public int DetailId{get;set;}
        [Required]
        public string Actor{get;set;}
        []
        public int MovieId{get;set;}
        public string Gender{get;set;}
        public string Role{get;set;}
    }
}