using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using SGMS.Models;
namespace SGMS.Controllers;
public class GradeController:Controller
{
    private readonly SGMSDbContext context;
    public GradeController(SGMSDbContext _context)
    {
        context = _context;
    }
    public IActionResult List()
    {
        var data=context.Grades.ToList();
        return View(data);
    }

}