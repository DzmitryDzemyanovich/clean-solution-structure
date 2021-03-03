using Fp.Hvr.Core.Values;

namespace Fp.Hvr.Core.Services
{
    public interface ISummariesService
    {
        int GetCount();
        SummaryText GetSummary(int number);
    }
}