using MediatR;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;

namespace Roulette.Application.Commands.CreateBetResult
{
    public class BetResultHandler : IRequestHandler<CreateBetResultCommand, string>
    {
        public async Task<string> Handle(CreateBetResultCommand request, CancellationToken cancellationToken)
        {
            using (var conn = new SQLiteConnection("Data Source=./DemoRouletteDB.db;Version=3"))
            {
                using (SQLiteCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.Parameters.AddWithValue("@Placebet_Id", request.PlacebetId);
                    comm.Parameters.AddWithValue("@Black", request.Black);
                    comm.Parameters.AddWithValue("@Red", request.Red);
                    comm.Parameters.AddWithValue("@Even", request.EvenNumber);
                    comm.Parameters.AddWithValue("@Odd", request.OddNumber);
                    comm.Parameters.AddWithValue("@FirstHalf", request.FirstHalf);
                    comm.Parameters.AddWithValue("@SecondHalf", request.SecondHalf);
                    comm.Parameters.AddWithValue("@FirstTwelve", request.FirstTwelve);
                    comm.Parameters.AddWithValue("@SecondTwelve", request.SecondTwelve);
                    comm.Parameters.AddWithValue("@ThirdTwelve", request.ThirdTwelve);
                    comm.Parameters.AddWithValue("@FirstTwotoOne", request.FirstTwoToOne);
                    comm.Parameters.AddWithValue("@SecondTwotoOne", request.SecondTwoToOne);
                    comm.Parameters.AddWithValue("@ThirdTwotoOne", request.ThirdTwoToOne);
                    comm.Parameters.AddWithValue("@Number", request.Number);
                    comm.CommandText = "Insert into BetResults(Placebet_Id,Black,Red,FirstTwelve,SecondTwelve,ThirdTwelve,FirstHalf,SecondHalf,Even,Odd,FirstTwotoOne,SecondTwotoOne,ThirdTwotoOne,Number) values (@Placebet_Id,@Black,@Red,@FirstTwelve,@SecondTwelve,@ThirdTwelve,@FirstHalf,@SecondHalf,@Even,@Odd,@FirstTwotoOne,@SecondTwotoOne,@ThirdTwotoOne,@Number)";
                    int value = comm.ExecuteNonQuery();
                }
            }

            return "added successfully";
        }
    }
}

