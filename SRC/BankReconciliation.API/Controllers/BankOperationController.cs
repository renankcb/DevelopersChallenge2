using BankReconciliation.Application.Services;
using BankReconciliation.Infrastructure.DataContracts.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankReconciliation.API.Controllers
{
    [Route("api/bank")]
    public class BankOperationController : Controller
    {
        #region Fields

        private readonly IBankOperationAppService bankOperationsService;

        #endregion

        #region Constructors

        public BankOperationController(IBankOperationAppService reconciliationService)
        {
            this.bankOperationsService = reconciliationService;
        }

        #endregion

        #region Public Methods

        [HttpPost]
        [Route("consolidate")]
        public async Task<IActionResult> ConsolidateExtractAsync([FromForm] IList<IFormFile> files)
        {
            try
            {
                BankConsolidateExtract response = await this.bankOperationsService.ParseAndConsolidateExtractsAsync(files);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
