using EMSApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace EmsApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DepartmentController:ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo=_repo;
        }
        [HttpGet]
        [Route("ListDept")]
        public IActionResult GetDept()
        {
            var data=repo.GetDepartments();
            return Ok(dept);
        }
    }
}