using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Retake.Models;
public class Books
{
    [Key]
    public int Id{get;set;}
    [MaxLength(99)]
    [Required(ErrorMessage ="BookName should be given")]
    public string BookName{get;set;}
    public string Type{get;set;}
    public Students Students{get;set;}

}