using MediatR;

namespace Roulette.Application.Commands.CreatePlaceBet
{
    public class CreatePlaceBetCommand : IRequest<string>
    {
        public string Id { get; set; }
    }
}
