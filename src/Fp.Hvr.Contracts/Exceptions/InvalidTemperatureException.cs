using System;

namespace Fp.Hvr.Contracts.Exceptions
{
    public class InvalidTemperatureException : Exception
    {
        public InvalidTemperatureException(float value, char sign)
            : base($"Given temperature {value}{sign} is out of the expected range")
        { }
    }
}
