using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace demowebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FruitsController:ControllerBase
    {
        static List<string> Fruits=new List<string>{"Apple","Orange","Mango","Grapes","Banana"};
        [HttpGet]
        [Route("ShowFruits")]
        public IEnumerable<string> GetFruits()
        {
            return Fruits;
        }
    }
}