using System.Linq;
using Fp.Hvr.Contracts.Values;
using Fp.Hvr.Core.Services;

namespace Fp.Hvr.Infrastructure.Services
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