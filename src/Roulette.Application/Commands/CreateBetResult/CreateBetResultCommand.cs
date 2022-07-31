using MediatR;

namespace Roulette.Application.Commands.CreateBetResult
{
    public class CreateBetResultCommand : IRequest<string>
    {
        public string PlacebetId { get; set; }
        public int Black { get; set; }
        public int Red { get; set; }
        public int FirstTwelve { get; set; }
        public int SecondTwelve { get; set; }
        public int ThirdTwelve { get; set; }
        public int FirstHalf { get; set; }
        public int SecondHalf { get; set; }
        public int OddNumber { get; set; }
        public int EvenNumber { get; set; }
        public int FirstTwoToOne { get; set; }
        public int SecondTwoToOne { get; set; }
        public int ThirdTwoToOne { get; set; }
        public int Number { get; set; }
    }
}
