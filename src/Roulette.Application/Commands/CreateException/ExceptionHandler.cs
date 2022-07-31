using MediatR;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Commands.CreateException
{
    public class ExceptionHandler : IRequestHandler<CreateExceptionCommand, string>
    {
        public async Task<string> Handle(CreateExceptionCommand request, CancellationToken cancellationToken)
        {
            using (var conn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                using (SQLiteCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@ErrorMessage", request.ErrorMessage);
                    comm.Parameters.AddWithValue("@StackTrace", request.StackTrace);
                    comm.CommandText = "Insert into GlobalException (ErrorMessage,StackTrace) values (@ErrorMessage, @StackTrace)";
                    int value = comm.ExecuteNonQuery();
                }
            }

            return "added successfully";
        }

    }
}
