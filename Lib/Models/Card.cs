using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
namespace LMS.Models;
public class Card
{
    public int Id{get;set;}
    [Required(ErrorMessage="Card Number should not be null")]
    public string CardNumber{get;set;}
    [Required(ErrorMessage="Member Name should not be null")]
    public string MemberName{get;set;}
    public string ExpiryDate{get;set;}

}