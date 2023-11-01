using System.ComponentModel.DataAnnotations;
namespace ProdMvc.Models;
public class Product{
    [Display(Name="Product ID")]
    [Key]
    [Required(ErrorMessage="ID is Compulsory")]
    public int Id{get;set;}
    [Required(ErrorMessage="Name cannot be Blank")]
    public string ?Name{get;set;}
    [Range(1000,90000,ErrorMessage="Price should be between 1000 and 90000")]
    public int price{get;set;}
    public int stock{get;set;}
}
