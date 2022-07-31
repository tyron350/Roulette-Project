using Dapper;
using MediatR;
using Roulette.Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Queries.GetCustomerBets
{
    public class CustomerBetHandler : IRequestHandler<GetCustomerBetQuery, List<CustomerBet>>
    {
        public async Task<List<CustomerBet>> Handle(GetCustomerBetQuery request, CancellationToken cancellationToken)
        {
            var list = new List<CustomerBet>();

            using (IDbConnection cnn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                var output = cnn.Query<CustomerBet>("select * from Customer_Bet", new DynamicParameters());

                list = output?.ToList();
            }

            return list;

        }
    }
}
