using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MoviesManagementMicroservice.Utils
{
    public class DataScraping
    {
        public static async Task<string> GetImdbMoviePosterUrlAsync(int id)
        {
            string idString = id.ToString().PadLeft(7, '0');

            string URL = "http://www.omdbapi.com/?i=tt" + idString + "&apikey=762854f2";
            string posterAddress = "";

            HttpClient client = new HttpClient();

            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(URL);

                dynamic jsonObject = JObject.Parse(json);
                posterAddress = jsonObject.Poster;
            }

            //Console.WriteLine("URL Link: " + URL);
            //Console.WriteLine("Movie Poster Link: " + posterAddress);
            return posterAddress;
        }

    }
}
