using MediatR;

namespace Roulette.Application.Commands.CreateException
{
    public class CreateExceptionCommand : IRequest<string>
    {
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
