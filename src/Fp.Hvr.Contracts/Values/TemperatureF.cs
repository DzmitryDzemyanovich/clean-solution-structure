using Fp.Hvr.Contracts.Exceptions;
using ValueOf;

namespace Fp.Hvr.Contracts.Values
{
    public class TemperatureF : ValueOf<float, TemperatureF>
    {
        protected override void Validate()
        {
            if (Value > 212 || Value < -460)
            {
                throw new InvalidTemperatureException(Value, 'F');
            }
        }
    }
}