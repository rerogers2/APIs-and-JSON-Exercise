using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        private HttpClient _client;
        public OpenWeatherMapAPI(HttpClient client) 
        {
            _client = client;
        }
        public void WeatherAPI()
        {
            var key = "5302e772fde987fc993ab818fa1929a8";
            var city = "houston";

            var weatherURL = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&APPID={key}&units=imperial";

            var weatherResult = _client.GetStringAsync(weatherURL).Result;

            JObject formatResult = JObject.Parse(weatherResult);
            var temp = formatResult["list"][0]["main"]["temp"];
            var feels = formatResult["list"][0]["main"]["feels_like"];
            var humidity = formatResult["list"][0]["main"]["humidity"];
            Console.WriteLine($"The current temperature in {char.ToUpper(city[0]) + city.Substring(1)}: {temp} degrees Fahrenheit.");
            Console.WriteLine($"There is a feels like temperature of: {feels} degrees Fahrenheit.");
            Console.WriteLine($"The current humidity is: {humidity} percent.");
        }
    }
}
