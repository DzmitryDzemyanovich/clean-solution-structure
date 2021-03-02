﻿using System;
using Fp.Hvr.Contracts.Values;

namespace Fp.Hvr.Contracts
{
    public class WeatherForecast
    {
        public WeatherForecast(DateTime date, int tempC, SummaryText summary)
        {
            Date = date;
            TemperatureC = TemperatureC.From(tempC);
            Summary = summary;
        }

        public DateTime Date { get; }

        public TemperatureC TemperatureC { get; }

        public SummaryText Summary { get; }

        public TemperatureF TemperatureF => TemperatureF.From(32 + (int)(TemperatureC / 0.5556));
    }
}
