using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotGuava_NetCore_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotGuava_NetCore_API.Controllers
{
    [Route("api/cypher")]
    [ApiController]
    public class CypherController : ControllerBase
    {
        // POST api/<CypherController>
        [HttpPost]
        public async Task<ActionResult<CypherDTO>> Post(CypherDTO cypherDTO)
        {
            if (cypherDTO == null)
            {
                return BadRequest();
            }

            var cypher = new Cypher(cypherDTO);

            if(cypherDTO.ToEncrypt)
            {
                await cypher.EncryptInputAsync();

                return new CypherDTO(cypher);
            }
            else
            {
                await cypher.DecryptInputAsync();

                return new CypherDTO(cypher);
            }
            
        }

    }
}
