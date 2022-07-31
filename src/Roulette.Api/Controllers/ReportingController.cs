using Microsoft.AspNetCore.Mvc;
using Roulette.Application.Interfaces;
using System.Threading.Tasks;

namespace Roulette_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportingController: ControllerBase
    {
        private readonly IReportingProcessManager _reportingProcessManager;
        public ReportingController( IReportingProcessManager reportingProcessManager)
        {
            _reportingProcessManager = reportingProcessManager;
        }

        [HttpGet, Route("GetPreviousSpinInformation")]
        public Task<string> GetCustomerAsync()
        {
            return _reportingProcessManager.GetPreviousSpinInformation();
        }
    }
}
