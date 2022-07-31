using MediatR;

namespace Roulette.Application.Commands.CloseBet
{
    public class CreateCloseBetCommand : IRequest<string>
    {
        public string PlacebetId { get; set; }
    }
}
