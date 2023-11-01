using Microsoft.AspNetCore.Mvc;
using CF.Models;
namespace CF.Controllers;
public class ProductController : Controller
{
    private readonly CFDbContext context;
    public ProductController(CFDbContext _context)
    {
        context= _context;
    }
    public IActionResult List()
    {
        return View();
    }
}