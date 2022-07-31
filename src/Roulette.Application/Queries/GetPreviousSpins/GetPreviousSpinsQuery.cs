using MediatR;
using Roulette.Data.Models;
using System.Collections.Generic;

namespace Roulette.Application.Queries.GetPreviousSpins
{
    public class GetPreviousSpinsQuery : IRequest<List<BetResult>>
    {
    }
}
