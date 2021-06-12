using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class Cypher
    {
        public string EncryptionKey { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public Cypher()
        {

        }
        public Cypher(CypherDTO cypherDTO)
        {
            EncryptionKey = cypherDTO.EncryptionKey;
            Input = cypherDTO.Input;
            Output = cypherDTO.Output;
        }

        public async Task EncryptInputAsync()
        {
            if (string.IsNullOrEmpty(Input))
            {
                Output = "Error: Input couldn't be determined";
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(EncryptionKey))
                {
                    Output = await Task.Run(() => dotGuava.Security.Cypher.Encrypt(Input));
                }
                else
                {
                    Output = await Task.Run(() => dotGuava.Security.Cypher.Encrypt(Input, EncryptionKey));
                }
            }
            catch (Exception)
            {
                Output = "Error: Input couldn't be encrypted";
            }            
        }
        public async Task DecryptInputAsync()
        {
            if (string.IsNullOrEmpty(Input))
            {
                Output = "Error: Input couldn't be determined";
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(EncryptionKey))
                {
                    Output = await Task.Run(() => dotGuava.Security.Cypher.Decrypt(Input));
                }
                else
                {
                    Output = await Task.Run(() => dotGuava.Security.Cypher.Decrypt(Input, EncryptionKey));
                }
            }
            catch (Exception)
            {
                Output = "Error: Input couldn't be decrypted";
            }
        }
    }
}
