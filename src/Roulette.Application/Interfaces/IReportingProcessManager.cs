using System.Threading.Tasks;

namespace Roulette.Application.Interfaces
{
    public interface IReportingProcessManager
    {
        Task<string> GetPreviousSpinInformation();
    }
}
