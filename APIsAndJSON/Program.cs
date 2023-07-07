using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region RonVSKanye
            var client = new HttpClient();
            var quote = new RonVSKanyeAPI(client);
            Console.WriteLine("How many time do you want Ron to talk?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < num; i++)
            {
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}\n");
                Console.WriteLine($"Ron Swanson: {quote.RonQuote()}\n");
            }
            #endregion
            //var client = new HttpClient();
            //var weather = new OpenWeatherMapAPI(client);

            //weather.WeatherAPI();
        }
    }
}
