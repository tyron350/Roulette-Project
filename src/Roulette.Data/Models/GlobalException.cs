namespace Roulette.Data.Models
{
    public class GlobalException
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
