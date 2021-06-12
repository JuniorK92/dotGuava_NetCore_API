using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class CypherDTO
    {
        public string EncryptionKey { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public bool ToEncrypt { get; set; }

        public CypherDTO()
        {

        }
        public CypherDTO(Cypher cypher)
        {
            EncryptionKey = cypher.EncryptionKey;
            Input = cypher.Input;
            Output = cypher.Output;
        }
    }
}
