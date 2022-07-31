using MediatR;
using Roulette.Data.Models;
using System.Collections.Generic;

namespace Roulette.Application.Queries.GetCustomerBets
{
    public class GetCustomerBetQuery : IRequest<List<CustomerBet>>
    {
    }
}
