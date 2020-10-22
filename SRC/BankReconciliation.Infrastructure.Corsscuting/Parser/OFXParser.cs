using BankReconciliation.Infrastructure.Corsscuting.Parser.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace BankReconciliation.Infrastructure.Corsscuting.Parser
{
    public class OFXParser
    {
        public static async Task<ExtractOFX> Parse(IFormFile file)
        {
            return await new OFXParser().GenerateExtract(file);
        }

        private Task<ExtractOFX> GenerateExtract(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
