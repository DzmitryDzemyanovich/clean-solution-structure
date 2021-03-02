using Fp.Hvr.Contracts.Values;

namespace Fp.Hvr.Core.Services
{
    public interface ISummariesService
    {
        int GetCount();
        SummaryText GetSummary(int number);
    }
}