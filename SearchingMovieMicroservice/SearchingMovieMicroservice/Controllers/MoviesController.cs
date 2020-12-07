
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ML_TestPredML.ConsoleApp;

namespace SearchingMovieMicroservice.Controllers
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
        public ActionResult<IEnumerable<float>> RecommendMoviesIdByKeyword(float userId, string keyword)
        {
            List<float> recommendations = SearchOperations.RecommendMoviesIdByKeyword(userId, keyword);
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
