using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class CreateQuote
    {
        private HttpClient _client;

        public CreateQuote(HttpClient client)
        {
            _client = client;
        }

        public string KanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Console.WriteLine($"Kanye: {kanyeQuote}\n");
            return kanyeQuote;
        }

        public string RonQuote()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            //Console.WriteLine($"Ron Swanson:  {ronQuote}\n");
            return ronQuote;
        }
    }
}