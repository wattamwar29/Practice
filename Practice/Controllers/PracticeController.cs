using Microsoft.AspNetCore.Mvc;
using Practice.Models;
namespace Practice.Controllers;
public class PracticeController:Controller
{
    private readonly PDbContext context;
    public PracticeController(PDbContext _context)
    {
        context = _context;
    }
}