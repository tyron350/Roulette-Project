using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roulette.Application.Inputs.Bet;
using Roulette.Application.Interfaces;
using System.Threading.Tasks;

namespace Roulette_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouletteController : ControllerBase
    {
        private readonly IBettingProcessManager _placebetProcessManager;

        public RouletteController(IBettingProcessManager placebetProcessManager)
        {
            _placebetProcessManager = placebetProcessManager;
        }

        [HttpPost, Route("PlaceCustomerBet")]
        public async Task<string> PlaceCustomerBet([FromBody] Customer customer)
        {
            return await _placebetProcessManager.ExecutePlaceBet(customer);
        }

        [HttpGet, Route("Spin")]
        public async Task<string> Spin()
        {
            return await _placebetProcessManager.ExecuteSpin();
        }

        [HttpGet, Route("Payout")]
        public async Task<string> Payout()
        {
            var message = await _placebetProcessManager.Payout();

            return message;
        }
    }
}
