using MediatR;
using Roulette.Data.Models;

namespace Roulette.Application.Queries.GetBetResult
{
    public class GetBetResultQuery : IRequest<BetResult>
    {
    }
}
