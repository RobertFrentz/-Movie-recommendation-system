
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ML_TestPredML.ConsoleApp;
using SearchingMovieMicroservice.Data;
using SearchingMovieMicroservice.Entities;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SearchingMovieMicroservice.Controllers
{
    [Route("api/v1/search")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private const string AdminJWT = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MTMxODU0ODQsInVzZXJJZCI6NH0.t2sFnEMWbtKdRxPQDNOE80IJS5PPK9qyPg0mlbrZ4B0";

        private readonly DataContext _context;
        private readonly HttpClient client;

        public MoviesController(DataContext context)
        {
            _context = context;
            client = new HttpClient();
        }

        private class Error
        {
            public Error(string _error_info)
            {
                error_info = _error_info;
            }
            public string error_info { get; set; }
        }


        [Route("category")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> RecommendMoviesIdByCategory([FromHeader] string Authentification_Token, string category)
        {
            string response = null;
            try
            {
                client.DefaultRequestHeaders.Add("Authentification_Token", Authentification_Token);
                response = await client.GetStringAsync("http://localhost:5050/api/v2/users/verify_token");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            if (response != null)
            {
                List<int> moviesId = _context.Movies.Where(x => x.Genres == category || x.Genres.Contains(category)).Select(x => x.Id).ToList();
                List<int> recommendations = SearchOperations.RecommendedMoviesIdByCategory(Convert.ToInt32(response), moviesId);
                if (recommendations == null || recommendations.Count == 0)
                {
                    return NoContent();
                }
                else
                {
                    return recommendations.ToArray();
                }
            }
            else
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
        }



        [Route("ratings")]
        [HttpGet]

        public async Task<ActionResult<List<int>>> RecommendMoviesOnlyByUserRatings([FromHeader] string Authentification_Token)
        {
            string response = null;
            try
            {
                client.DefaultRequestHeaders.Add("Authentification_Token", Authentification_Token);
                response = await client.GetStringAsync("http://localhost:5050/api/v2/users/verify_token");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            if (response != null)
            {
                HttpResponseMessage httpResponseMessage;
                try
                {
                    httpResponseMessage = await client.GetAsync("http://localhost:5050/api/v1/ratings");
                    httpResponseMessage.EnsureSuccessStatusCode();
                    var moviesIdWithRatings = httpResponseMessage.Content.ReadAsAsync<Dictionary<int, int>>().Result;
                    string category = GetMostRatedCategory(moviesIdWithRatings);
                    string tag = GetMostRatedTag(moviesIdWithRatings);
                    /*foreach(KeyValuePair<int, int> movie in moviesIdWithRatings)
                    {
                        Console.WriteLine("MovieId: " + movie.Key + " Rating: " + movie.Value);
                    }*/
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
                return Ok();
            }
            else
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
        }

        [Route("keyword")]
        [HttpGet]
        public async Task<ActionResult<List<int>>> RecommendMoviesIdByKeyword([FromHeader] string Authentification_Token, string keyword)
        {
            string response = null;
            try
            {
                client.DefaultRequestHeaders.Add("Authentification_Token", Authentification_Token);
                response = await client.GetStringAsync("http://localhost:5050/api/v2/users/verify_token");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            if (response != null)
            {
                string filteredKeyword = FilteringOperations.FilterKeyword(keyword);
                Console.WriteLine("Filtered Keyword: " + filteredKeyword);
                List<int> moviesIdTag = _context.MovieWithTags.Where(x => x.Tag.Replace(" ", "").ToLower().Contains(filteredKeyword) || filteredKeyword.Contains(x.Tag.Replace(" ", "").ToLower()))
                                                              .Select(x => x.MovieId)
                                                              .ToList();
                List<int> moviesIdTitle = _context.Movies.Where(x => x.Title.Replace(" ", "").ToLower().Contains(filteredKeyword)).Select(x => x.Id).ToList();
                Console.WriteLine("moviesTag count : " + moviesIdTag.Count + " moviesTitle count : " + moviesIdTitle.Count);
                List<int> recommendations = SearchOperations.RecommendMoviesIdByKeyword(Convert.ToInt32(response), moviesIdTag, moviesIdTitle);
                if (recommendations.Count == 0)
                {
                    return NoContent();
                }
                else
                {
                    return recommendations;
                }
            }
            else
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
        }

        private string GetMostRatedTag(Dictionary<int, int> movies)
        {
            List<int> moviesId = new List<int>();
            foreach (KeyValuePair<int, int> movie in movies)
            {
                moviesId.Add(movie.Key);
            }
            return _context.MovieWithTags
                        .Where(m => moviesId.Contains(m.MovieId))
                        .AsEnumerable()
                        .GroupBy(m => m.Tag)
                        .OrderByDescending(m => m.Count())
                        .Select(m => m.Key)
                        .FirstOrDefault();
        }

        private string GetMostRatedCategory(Dictionary<int, int> movies)
        {
            Dictionary<string, int> categories = new Dictionary<string, int>();
            List<int> moviesId = new List<int>();
            foreach (KeyValuePair<int, int> movie in movies)
            {
                moviesId.Add(movie.Key);
            }
            var recentMovies = _context.Movies
                                  .Where(m => moviesId.Contains(m.Id))
                                  .Select(m => m.Genres)
                                  .ToList();

            foreach (string movie in recentMovies)
            {
                int lastPosition = 0;
                string category;
                for (int i = 0; i < movie.Length; i++)
                {
                    if (movie[i] == '|')
                    {
                        category = movie.Substring(lastPosition, i - lastPosition);
                        if (categories.ContainsKey(category))
                        {
                            categories[category] += 1;
                        }
                        else
                        {
                            categories.Add(category, 1);
                        }
                        lastPosition += i - lastPosition + 1;
                    }
                }
                category = movie.Substring(lastPosition, movie.Length - lastPosition);
                if (categories.ContainsKey(category))
                {
                    categories[category] += 1;
                }
                else
                {
                    categories.Add(category, 1);
                }
            }
            return categories.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
