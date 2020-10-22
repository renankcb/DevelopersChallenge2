using BankReconciliation.Application.Extensions;
using BankReconciliation.Domain.Entities;
using BankReconciliation.Domain.Services;
using BankReconciliation.Infrastructure.Corsscuting.Parser;
using BankReconciliation.Infrastructure.DataContracts.DTO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankReconciliation.Application.Services
{
    public class ReconciliationAppService : IReconciliationAppService
    {
        #region Fields

        private readonly IReconciliationDomainService reconciliationDomainService;

        #endregion

        #region Constructors

        public ReconciliationAppService(IReconciliationDomainService reconciliationDomainService)
        {
            this.reconciliationDomainService = reconciliationDomainService;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Parse and map extracts to reconciliate
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public async Task<ExtractDTO> ReconciliateAsync(IList<IFormFile> files)
        {
            List<Extract> extracts = new List<Extract>();

            // Parse each ofx file and map it to domain
            foreach (var file in files)
            {
                var parsedExtract = await OFXParser.Parse(file);
                var extract = parsedExtract.ToDomain();

                extracts.Add(extract);
            }

            // Reconciliate extracts
            Extract result = this.reconciliationDomainService.Reconciliate(extracts);

            // Map result to DTO
            var response = result.ToDTO();

            return response;
        }

        #endregion
    }
}
