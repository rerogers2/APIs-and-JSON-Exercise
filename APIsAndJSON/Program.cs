using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            var quote = new CreateQuote(client);

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}\n");
                Console.WriteLine($"Ron Swanson: {quote.RonQuote()}\n");
            }
        }
    }
}
