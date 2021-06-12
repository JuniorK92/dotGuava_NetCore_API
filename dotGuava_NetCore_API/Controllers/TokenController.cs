using dotGuava_NetCore_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        // POST api/<TokenController>
        [HttpPost]
        public async Task<ActionResult<TokenDTO>> Post(TokenDTO tokenDTO)
        {
            if (tokenDTO == null)
            {
                return BadRequest();
            }

            var token = new Token(tokenDTO);

            await token.GenerateTokensAsync();

            return new TokenDTO(token);
        }
    }
}
