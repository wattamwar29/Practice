using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
namespace LMS.Models;
public class Book
{
    

    public int Id{get;set;}
    [Required(ErrorMessage="Name Cannot Be Blank")]
    [MaxLength(100)]
   // [Column("DeptName")]
    public string Title{get;set;}
    [MaxLength(100)]
    public string Author{get;set;}
    [MaxLength(50)]
    public string PublishedYear{get;set;}
    public ICollection<Card>Cards{get;set;}

}