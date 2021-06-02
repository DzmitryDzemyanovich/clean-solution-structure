using System;

namespace PublicContracts.Models
{
    public class WeatherForecastViewModel
    {
        public DateTime Date { get; set; }
        public float TemperatureC { get; set; }
        public string Summary { get; set; }
        public float TemperatureF { get; set; }
    }
}
