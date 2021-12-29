using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mc.Core.Domain;
using Mc.Manager.Interfaces;
using Mc.Manager.Validator;

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
        public async Task<IActionResult> Post([FromBody]Client client)
        {
            var c = await clientManager.InsertClientAsync(client);
            return CreatedAtAction(nameof(Get), new { id = client.Id }, c);
           
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Client client)
        {
            var c = await clientManager.UpdateClientAsync(client);
            if (c == null)
            {
                return NotFound();
            }

            return Ok(c);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await clientManager.DeleteClientAsync(id);
            return NoContent();
        }

    }
}
