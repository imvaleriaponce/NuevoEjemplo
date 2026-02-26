namespace WebApplicationEjemploo
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int MyProperty2 { get; set; }

        public int MyProperty { get; set; }

        public int MyProperty3 { get; set; }

        public int MyProperty4 { get; set; }
    }
}
