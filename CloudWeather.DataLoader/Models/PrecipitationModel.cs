namespace CloudWeather.Report.Models
{
    internal class PrecipitationModel
    {
        public DateTime CreatedOn { get; set; }
        public decimal AmountInches { get; set; }
        public string WeatherType { get; set; }
        public string ZipCode { get; set;}
    }
}