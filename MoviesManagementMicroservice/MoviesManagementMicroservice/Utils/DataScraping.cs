using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviesManagementMicroservice.Utils
{
    public class DataScraping
    {
        public static async Task<string> GetImdbMoviePosterUrlAsync(int id)
        {
            string idString = id.ToString().PadLeft(7, '0');

            string URL = "http://www.omdbapi.com/?i=tt" + idString + "&apikey=36671c0b";
            string posterAddress = "";

            HttpClient httpClient = new HttpClient();


            var request = new HttpRequestMessage(HttpMethod.Get, URL);
            using var httpResponse = await httpClient.SendAsync(request);

            if ((int)httpResponse.StatusCode != 200)
            {
                Console.WriteLine($"EROARE GetImdbMoviePosterUrlAsync: {httpResponse.ReasonPhrase}, a expirat token-ul?");
                return null;
            }

            var json = await httpClient.GetStringAsync(URL);
            dynamic jsonObject = JObject.Parse(json);
            posterAddress = jsonObject.Poster;

            //Console.WriteLine("URL Link: " + URL);
            //Console.WriteLine("Movie Poster Link: " + posterAddress);
            return posterAddress;
        }

        public static async Task<string> GetImdbMovieData(int id)
        {
            string idString = id.ToString().PadLeft(7, '0');

            string URL = "http://www.omdbapi.com/?i=tt" + idString + "&plot=full&apikey=36671c0b";

            string jsonString = "";

            HttpClient httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, URL);
            using var httpResponse = await httpClient.SendAsync(request);

            if ((int)httpResponse.StatusCode != 200)
            {
                Console.WriteLine($"EROARE GetImdbMovieData: {httpResponse.ReasonPhrase}, a expirat token-ul?");
                return null;
            }

            jsonString = await httpClient.GetStringAsync(URL);

            //Console.WriteLine("URL Link: " + URL);
            //Console.WriteLine("JSON is: " + jsonString);
            return jsonString;
        }
    }
}
