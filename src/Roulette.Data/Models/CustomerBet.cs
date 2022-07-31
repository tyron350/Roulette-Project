namespace Roulette.Data.Models
{
    public class CustomerBet : BetResult
    {
        public string Customer_Id { get; set; }
        public int BetAmount { get; set; }
        public int NumberFull { get; set; }
        public int NumberSplit { get; set; }
    }
}
