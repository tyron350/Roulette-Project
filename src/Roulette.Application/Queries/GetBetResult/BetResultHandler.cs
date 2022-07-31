using Dapper;
using MediatR;
using Roulette.Data.Models;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Queries.GetBetResult
{
    public class BetResultHandler : IRequestHandler<GetBetResultQuery, BetResult>
    {
        public async Task<BetResult> Handle(GetBetResultQuery request, CancellationToken cancellationToken)
        {
            var list = new BetResult();

            using (IDbConnection cnn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                var output = cnn.Query<BetResult>("SELECT b.* from BetResults b INNER JOIN PlaceBets pb on b.Placebet_Id = pb.Id Where pb.IsBetPaid = 0", new DynamicParameters());

                list = output.Single();
            }

            return list;

        }

    }
}
