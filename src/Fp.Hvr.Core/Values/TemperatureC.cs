using Fp.Hvr.Contracts.Exceptions;
using ValueOf;

namespace Fp.Hvr.Core.Values
{
    public class TemperatureC : ValueOf<int, TemperatureC>
    {
        protected override void Validate()
        {
            if (Value > 200 || Value < -273)
            {
                throw new InvalidTemperatureException(Value, 'C');
            }
        }
    }
}