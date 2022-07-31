using Dapper;
using MediatR;
using Roulette.Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Queries.GetPreviousSpins
{
    public class PreviousSpinsHandler : IRequestHandler<GetPreviousSpinsQuery, List<BetResult>>
    {
        public async Task<List<BetResult>> Handle(GetPreviousSpinsQuery request, CancellationToken cancellationToken)
        {
            var list = new List<BetResult>();

            using (IDbConnection cnn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                var output = cnn.Query<BetResult>("SELECT * from BetResults", new DynamicParameters());

                list = output.ToList();
            }

            return list;

        }
    }
}
