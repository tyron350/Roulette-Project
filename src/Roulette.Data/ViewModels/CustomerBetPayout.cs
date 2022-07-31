using System.Collections.Generic;

namespace Roulette.Data.ViewModels
{
    public class CustomerBetPayout
    {
        public string CustomerIdentityNumber { get; set; }
        public decimal TotalPayout { get; set; }
        public List<CustomerBetBreakdown> BetBreakdown { get; set; }
    }
}
