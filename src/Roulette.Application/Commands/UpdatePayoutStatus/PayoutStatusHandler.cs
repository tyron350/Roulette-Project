using MediatR;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Commands.UpdatePayoutStatus
{
    public class PayoutStatusHandler : IRequestHandler<UpdatePayoutStatusCommand, string>
    {
        public async Task<string> Handle(UpdatePayoutStatusCommand request, CancellationToken cancellationToken)
        {
            using (var conn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                using (SQLiteCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@Placebet_Id", request.PlacebetId);
                    comm.CommandText = "Update Placebets Set IsBetPaid = 1 where Id = @Placebet_Id";
                    int value = comm.ExecuteNonQuery();
                }
            }
            return "done";
        }
    }
}
