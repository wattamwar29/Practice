using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens.Jwt;
using Microsoft
namespace jwt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       [HttpPost]
       public IActionResult Login([FromBody] LoginModel user)
       {
        if(user is null)
        {
            return BadRequest("Invalid Client request");
        } 
        //code to access the user and password from database
        if(user.UserName == "Tom" && user.Password == "Jerry")
        {
            var secretKey=new Symm
        }
       }
    }
}