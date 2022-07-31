using MediatR;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Commands.CloseBet
{
    public class CloseBetHandler : IRequestHandler<CreateCloseBetCommand, string>
    {
        public async Task<string> Handle(CreateCloseBetCommand request, CancellationToken cancellationToken)
        {
            using (var conn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                using (SQLiteCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@Placebet_Id", request.PlacebetId);
                    comm.CommandText = "Update Placebets Set IsBetOpen = 0 where Id = @Placebet_Id";
                    int value = comm.ExecuteNonQuery();
                }
            }
            return "done";
        }

    }
}
