using BankReconciliation.Application.Services;
using BankReconciliation.Infrastructure.DataContracts.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankReconciliation.API.Controllers
{
    [Route("api/[controller]")]
    public class ReconciliationController : Controller
    {
        #region Fields

        private readonly IReconciliationAppService reconciliationService;

        #endregion

        #region Constructors

        public ReconciliationController(IReconciliationAppService reconciliationService)
        {
            this.reconciliationService = reconciliationService;
        }

        #endregion

        #region Public Methods

        [HttpPost]
        public async Task<IActionResult> ReconciliateAsync([FromForm] IList<IFormFile> files)
        {
            try
            {
                ReconciliationDTO response = await this.reconciliationService.ReconciliateAsync(files);

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
