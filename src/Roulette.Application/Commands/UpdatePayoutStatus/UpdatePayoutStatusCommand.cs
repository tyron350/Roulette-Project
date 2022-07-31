using MediatR;

namespace Roulette.Application.Commands.UpdatePayoutStatus
{
    public class UpdatePayoutStatusCommand : IRequest<string>
    {
        public string PlacebetId { get; set; }
    }
}
