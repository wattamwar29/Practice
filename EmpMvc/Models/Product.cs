using System.ComponentModel.DataAnnotations;
namespace EmpMvc.Models;
public class Product{
    [Display(Name="Product ID")]
    [Key]
    
    [Required(ErrorMessage="ID is Compulsory")]
    public int Id{get;set;}

    [Required(ErrorMessage="Name cannot be Blank")]
    public string Name{get;set;}
    
    [Range(100,900,ErrorMessage="Price should be between 100 and 900")]
    public int price{get;set;}
    
    public int stock{get;set;}
}
