
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
            if (recommendations.Count == 0)
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
        public ActionResult<IEnumerable<int>> RecommendMoviesIdByKeyword(float userId, string keyword)
        {
            List<int> moviesIdTag = _context.MovieWithTags.Where(x => x.Tag.Contains(keyword) || keyword.Contains(x.Tag))
                                                          .Select(x => x.MovieId)
                                                          .ToList();
            List<int> moviesIdTitle = _context.Movies.Where(x => x.Title.Contains(keyword)).Select(x => x.Id).ToList();
            Console.WriteLine("moviesTag count : " + moviesIdTag.Count + " moviesTitle count : " + moviesIdTitle.Count);
            List<int> recommendations = SearchOperations.RecommendMoviesIdByKeyword(userId, moviesIdTag, moviesIdTitle);
            if(recommendations.Count == 0)
            {
                return NoContent();
            } else
            {
                return recommendations.ToArray();
            }
        }
    }
}
