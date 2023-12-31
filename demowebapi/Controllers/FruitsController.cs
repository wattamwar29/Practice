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
        [HttpGet()]
        [Route("ShowFruits/{id}")]
        public string GetFruits(int id)
        {
            return Fruits[id];
        }
        [HttpPost]
        [Route("AddFruit")]
        public void Post([FromBody] string data)
        {
            Fruits.Add(data);
        }
        [HttpPut]
        [Route("Edit/{id}")]
        public void Put(int id,[FromBody] string data)
        {
            Fruits[id]=data;
        }
        [HttpDelete]
        [Route("Kill/{id}")]
        public void Delete(int id,[FromBody] string data)
        {
            Fruits.RemoveAt(id);
        }
    }
}