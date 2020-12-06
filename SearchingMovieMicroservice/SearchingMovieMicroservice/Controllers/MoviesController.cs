
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ML_TestPredML.ConsoleApp;

namespace SearchingMovieMicroService.Controllers
{
    [Route("api/v1/search")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [Route("category")]
        [HttpGet]
        public ActionResult<IEnumerable<float>> RecommendMoviesIdByCategory(float userId, string category)
        {
            List<float> recommendations = SearchOperations.RecommendedMoviesIdByCategory(userId, category);
            if (recommendations.Capacity == 0)
            {
                return NoContent();
            }
            else
            {
                return recommendations.ToArray();
            }

        }

        [Route("tag")]
        [HttpGet]
        public ActionResult<IEnumerable<float>> RecommendMoviesIdByTag(float userId, string tag)
        {
            List<float> recommendations = SearchOperations.RecommendedMoviesIdByTag(userId, tag);
            if (recommendations.Capacity == 0)
            {
                return NoContent();
            }
            else
            {
                return recommendations.ToArray();
            }
        }

        [Route("title")]
        [HttpGet]
        public ActionResult<IEnumerable<float>> RecommendMoviesIdByTitle(float userId, string title)
        {
            List<float> recommendations = SearchOperations.RecommendedMoviesIdByTitle(userId, title);
            if(recommendations.Capacity == 0)
            {
                return NoContent();
            } else
            {
                return recommendations.ToArray();
            }
        }
    }
}
