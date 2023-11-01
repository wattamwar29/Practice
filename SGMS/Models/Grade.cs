using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace SGMS.Models;
{
    public class Grade
    {
        public int GradeId{get;set;}
        public string GradeName{get;set;}
        public string Section {get;set;}
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}