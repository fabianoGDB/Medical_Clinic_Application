using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mc.Core.Domain;
using Mc.Manager.Interfaces;

namespace Mc.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientManager clientManager;
        public ClientsController(IClientManager clientManager)
        {
            this.clientManager = clientManager;
        }
        // GET: ClientController
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await clientManager.GetClientsAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await clientManager.GetClientAsync(id));
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
