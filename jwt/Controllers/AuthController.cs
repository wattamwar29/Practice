using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Security;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
 
namespace jwt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel user){
            if(user is null){
                return BadRequest("Invalid Client Request");
            }
            //code to access the user and password from database
            if(user.UserName == "Tom" && user.Password=="Jerry"){
                var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer:"http//0.0.0.0:8080",
                    audience:"http//0.0.0.:8080",
                    claims:new List<Claim>(),
                    expires:DateTime.Now.AddMinutes(10),
                    signingCredentials:signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new AuthenticateResponse{Token=tokenString});
            }
            return Unauthorized();
        }
 
 
    }
}