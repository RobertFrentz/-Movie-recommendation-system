
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ML_TestPredML.ConsoleApp;
using SearchingMovieMicroservice.Data;
using SearchingMovieMicroservice.Entities;
using System.Linq;
using System;

namespace SearchingMovieMicroservice.Controllers
{
    [Route("api/v1/search")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly DataContext _context;

        public MoviesController(DataContext context)
        {
            _context = context;
        }

        [Route("category")]
        [HttpGet]
        public ActionResult<IEnumerable<int>> RecommendMoviesIdByCategory(float userId, string category)
        {
            List<int> moviesId = _context.Movies.Where(x => x.Genres == category).Select(x => x.Id).ToList();
            List<int> recommendations = SearchOperations.RecommendedMoviesIdByCategory(userId, moviesId);
            if (recommendations == null || recommendations.Count == 0)
            {
                return NoContent();
            }
            else
            {
                return recommendations.ToArray();
            }

        }

        [Route("keyword")]
        [HttpGet]
        public ActionResult<List<int>> RecommendMoviesIdByKeyword(float userId, string keyword)
        {
            string filteredKeyword = FilteringOperations.FilterKeyword(keyword);
            Console.WriteLine("Filtered Keyword: " + filteredKeyword);
            List<int> moviesIdTag = _context.MovieWithTags.Where(x => x.Tag.Replace(" ", "").ToLower().Contains(filteredKeyword) || filteredKeyword.Contains(x.Tag.Replace(" ", "").ToLower()))
                                                          .Select(x => x.MovieId)
                                                          .ToList();
            List<int> moviesIdTitle = _context.Movies.Where(x => x.Title.Replace(" ", "").ToLower().Contains(filteredKeyword)).Select(x => x.Id).ToList();
            Console.WriteLine("moviesTag count : " + moviesIdTag.Count + " moviesTitle count : " + moviesIdTitle.Count);
            List<int> recommendations = SearchOperations.RecommendMoviesIdByKeyword(userId, moviesIdTag, moviesIdTitle);
            if(recommendations.Count == 0)
            {
                return NoContent();
            } else
            {
                return recommendations;
            }
        }
    }
}
