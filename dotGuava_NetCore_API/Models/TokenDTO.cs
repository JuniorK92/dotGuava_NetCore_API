using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class TokenDTO
    {
        public string ReferenceKey { get; set; }
        public uint Length { get; set; }
        public List<string> TokenList { get; set; }

        public TokenDTO()
        {

        }

        public TokenDTO(Token token)
        {
            ReferenceKey = token.ReferenceKey;
            Length = token.Length;
            TokenList = token.TokenList;
        }
    }
}
