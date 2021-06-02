using Core.Values;

namespace Core.Services
{
    public interface ISummariesService
    {
        int GetCount();
        SummaryText GetSummary(int number);
    }
}