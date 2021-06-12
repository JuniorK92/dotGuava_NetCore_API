using dotGuava_NetCore_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Controllers
{
    [Route("api/mac")]
    [ApiController]
    public class MacController : ControllerBase
    {
        // POST api/<MacController>
        [HttpPost]
        public async Task<ActionResult<MacDTO>> Post(MacDTO macDTO)
        {
            if (macDTO == null)
            {
                return BadRequest();
            }

            var mac = new Mac(macDTO);

            await mac.GetMacAddressesListAsync();

            return new MacDTO(mac);
        }
    }
}
