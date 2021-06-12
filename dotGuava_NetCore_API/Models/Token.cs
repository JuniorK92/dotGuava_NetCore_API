using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class Token
    {
        public string ReferenceKey { get; set; }
        public uint Length { get; set; }
        public List<string> TokenList { get; set; }

        public Token()
        {
            TokenList = new List<string>();
        }
        public Token(TokenDTO tokenDTO)
        {
            ReferenceKey = tokenDTO.ReferenceKey;
            Length = tokenDTO.Length;
            TokenList = tokenDTO.TokenList;
        }

        public async Task GenerateTokensAsync()
        {
            TokenList = new List<string>();

            if (string.IsNullOrEmpty(ReferenceKey) == false && (Length >= 4 && Length <= 12))
            {
                TokenList = await Task.Run(() => dotGuava.Essential.Token.GetStringTokenList(Length, ReferenceKey).ToList());
            }
        }
    }
}
