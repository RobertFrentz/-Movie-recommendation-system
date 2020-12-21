
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using UserManagementMicroservice.Data;
using UserManagementMicroservice.Entities;

namespace UserManagementMicroservice.Controllers
{
    [Route("api/v1/ratings")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly DataContext _context;

        public RatingsController(DataContext context)
        {
            _context = context;
        }

        public class RequestRating
        {
            public int MovieId { get; set; }

            public int Score { get; set; }
        }

        private class Error
        {
            public Error(string _error_info)
            {
                error_info = _error_info;
            }
            public string error_info { get; set; }
        }

        [HttpGet]
        public ActionResult<int> GetRating(int movieId, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string jwtClaims = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string jwtUserId = jwtClaims.Remove(jwtClaims.Length - 1);
                var rating = _context.Ratings.Where(u => u.Id == Convert.ToInt32(jwtUserId) && u.MovieId == movieId).FirstOrDefault();
                if (rating == null)
                {
                    return NotFound(new Error("Rating doesn't exist"));
                }
                else
                {
                    return rating.Score;
                }
            }
        }

        [HttpPut]
        public IActionResult PutRating([FromBody] RequestRating requestRating, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string jwtClaims = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string jwtUserId = jwtClaims.Remove(jwtClaims.Length - 1);
                var rating = _context.Ratings.Where(u => u.Id == Convert.ToInt32(jwtUserId) && u.MovieId == requestRating.MovieId).FirstOrDefault();
                if (rating == null)
                {
                    return NotFound(new Error("Rating doesn't exist"));
                }
                if (requestRating.Score >= 1 && requestRating.Score <= 5)
                {
                    return BadRequest(new Error("Score must be between 1 and 5"));
                }
                else
                {
                    rating.Score = requestRating.Score;
                    _context.SaveChanges();
                    return NoContent();
                }

            }
        }

        [HttpPost]
        public IActionResult PostRating([FromBody] RequestRating requestRating, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string jwtClaims = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string jwtUserId = jwtClaims.Remove(jwtClaims.Length - 1);
                if(_context.Ratings.Any(u => u.Id == Convert.ToInt32(jwtUserId) && u.MovieId == requestRating.MovieId))
                {
                    return Conflict(new Error("Rating already exists"));
                }
                if(requestRating.Score >= 1 && requestRating.Score <= 5)
                {
                    return BadRequest(new Error("Score must be between 1 and 5"));
                }
                else
                {
                    Rating newRating = new Rating();
                    newRating.MovieId = requestRating.MovieId;
                    newRating.UserId = Convert.ToInt32(jwtUserId);
                    newRating.Score = requestRating.Score;
                    _context.Add(newRating);
                    _context.SaveChanges();
                    return NoContent();
                }

            }

        }

        [HttpDelete]

        public IActionResult DeleteRating([FromBody] RequestRating requestRating, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string jwtClaims = jwtDecoded.Split(',').ToList()[1].Split(':').ToList()[1];
                string jwtUserId = jwtClaims.Remove(jwtClaims.Length - 1);
                var rating = _context.Ratings.Where(u => u.Id == Convert.ToInt32(jwtUserId) && u.MovieId == requestRating.MovieId).FirstOrDefault();
                if (rating == null)
                {
                    return NotFound(new Error("Rating doesn't exist"));
                }
                else
                {
                    _context.Remove(rating);
                    _context.SaveChanges();
                    return NoContent();
                }
            }
        }
    }
    
}
