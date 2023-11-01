using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using SGMS.Models;
namespace SGMS.Controllers;
public class StudentController:Controller
{
    private readonly SGMSDbContext context;
    public StudentController(SGMSDbContext _context)
    {
        context = _context;
    }
    public IActionResult List()
    {
        var data=context.Students.ToList();
        return View(data);
    }

}