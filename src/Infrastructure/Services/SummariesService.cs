using Core.Services;
using Core.Values;
using System.Linq;

namespace Infrastructure.Services
{
    public class SummariesService : ISummariesService
    {
        private static readonly SummaryText[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        }
            .Select(SummaryText.From)
            .ToArray();

        public int GetCount() =>
            Summaries.Length;

        public SummaryText GetSummary(int number) =>
            Summaries[number];
    }
}