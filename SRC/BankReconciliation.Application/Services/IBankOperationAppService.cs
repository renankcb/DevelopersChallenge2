using BankReconciliation.Infrastructure.DataContracts.DTO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankReconciliation.Application.Services
{
    public interface IBankOperationAppService
    {
        Task<BankConsolidateExtractDTO> ParseAndConsolidateExtractsAsync(IList<IFormFile> files);
    }
}
