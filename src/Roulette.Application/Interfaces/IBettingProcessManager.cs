using Roulette.Application.Inputs.Bet;
using System.Threading.Tasks;

namespace Roulette.Application.Interfaces
{
    public interface IBettingProcessManager
    {
        Task<string> ExecutePlaceBet(Customer CustomerBet);
        Task<string> ExecuteSpin();
       Task<string> Payout();
    }
}
