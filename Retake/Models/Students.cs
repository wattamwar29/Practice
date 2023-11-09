using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Retake.Models;
public class Students
{
    public int Id {get;set;}
    public string Name{get;set;}
    public int NOB{get;set;}
    public ICollection<Books> Books{get;set;}
}