using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mc.Core.Domain;

namespace Mc.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // GET: ClientController
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<Client>(){
                new Client { Id = 1, Name = "Robinso", BirthDate = new DateTime(1990, 01, 01) },

                new Client { Id = 1, Name = "Robinso", BirthDate = new DateTime(1990, 01, 01)
                }
            });
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "values";
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
