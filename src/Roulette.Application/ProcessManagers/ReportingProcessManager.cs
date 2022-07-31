using MediatR;
using Roulette.Application.Interfaces;
using Roulette.Application.Queries.GetPreviousSpins;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Roulette.Application.ProcessManagers
{
    public class ReportingProcessManager : IReportingProcessManager
    {
        private readonly IMediator _mediator;

        public ReportingProcessManager(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<string> GetPreviousSpinInformation()
        {
            var previousSpins = await _mediator.Send(new GetPreviousSpinsQuery());
            return JsonSerializer.Serialize(previousSpins);
        }
    }
}
