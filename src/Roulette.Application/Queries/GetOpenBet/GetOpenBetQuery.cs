using MediatR;
using Roulette.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.Application.Queries.GetOpenBet
{
    public class GetOpenBetQuery : IRequest<PlaceBet>
    {
    }
}
