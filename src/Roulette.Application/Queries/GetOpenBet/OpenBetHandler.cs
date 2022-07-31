using Dapper;
using MediatR;
using Roulette.Data.Models;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Queries.GetOpenBet
{
    public class OpenBetHandler : IRequestHandler<GetOpenBetQuery, PlaceBet?>
    {
        public async Task<PlaceBet?> Handle(GetOpenBetQuery request, CancellationToken cancellationToken)
        {
            var list = new PlaceBet();

            using (IDbConnection cnn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                var pb = cnn.Query<PlaceBet>("select * from PlaceBets where IsBetOpen = 1 ", new DynamicParameters());

                if(pb.Count() > 0)
                {
                    list = pb.Single();
                }
            }

            return list;

        }
    }
}
