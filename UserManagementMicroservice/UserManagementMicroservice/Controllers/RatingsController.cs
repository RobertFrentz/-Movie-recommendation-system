
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using UserManagementMicroservice.Data;
using UserManagementMicroservice.Entities;

namespace UserManagementMicroservice.Controllers
{
    [Route("api/v1/ratings")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        public const string AdminJWT = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MTMxODU0ODQsInVzZXJJZCI6NH0.t2sFnEMWbtKdRxPQDNOE80IJS5PPK9qyPg0mlbrZ4B0";

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

        [HttpGet("{movieId}")]
        public ActionResult<int> GetRating(int movieId, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string id = JWT.ExtractUserId(jwtDecoded);
                var rating = _context.Ratings.Where(u => u.UserId == Convert.ToInt32(id) && u.MovieId == movieId).FirstOrDefault();
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

        [HttpGet]
        public ActionResult<Dictionary<int,int>> GetRatings([FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string id = JWT.ExtractUserId(jwtDecoded);
                var ratings = _context.Ratings.Where(u => u.UserId == Convert.ToInt32(id)).ToDictionary(u => u.MovieId, u => u.Score);
                if (ratings.Count == 0)
                {
                    return NotFound(new Error("User doesn't have ratings"));
                }
                else
                {
                    Console.WriteLine("Ratings: " + ratings);
                    return ratings;
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
                string id = JWT.ExtractUserId(jwtDecoded);
                var rating = _context.Ratings.Where(u => u.UserId == Convert.ToInt32(id) && u.MovieId == requestRating.MovieId).FirstOrDefault();
                if (rating == null)
                {
                    return NotFound(new Error("Rating doesn't exist"));
                }
                if (requestRating.Score < 1 || requestRating.Score > 5)
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
                string id = JWT.ExtractUserId(jwtDecoded);
                if (_context.Ratings.Any(u => u.UserId == Convert.ToInt32(id) && u.MovieId == requestRating.MovieId))
                {
                    return Conflict(new Error("Rating already exists"));
                }
                if (requestRating.Score < 1 || requestRating.Score > 5)
                {
                    return BadRequest(new Error("Score must be between 1 and 5"));
                }
                
                else
                {
                    Rating newRating = new Rating();
                    newRating.MovieId = requestRating.MovieId;
                    newRating.UserId = Convert.ToInt32(id);
                    newRating.Score = requestRating.Score;
                    _context.Add(newRating);
                    _context.SaveChanges();
                    return NoContent();
                }

            }

        }

        [HttpDelete("{movieId}")]
        public IActionResult DeleteRating(int movieId, [FromHeader] string Authentification_Token)
        {
            string jwtDecoded = JWT.CheckJWT(Authentification_Token);
            if (jwtDecoded == "Token has expired" || jwtDecoded == "Token has invalid signature")
            {
                return Unauthorized(new Error("Token has invalid signature or expired"));
            }
            else
            {
                string id = JWT.ExtractUserId(jwtDecoded);
                var rating = _context.Ratings.Where(u => u.UserId == Convert.ToInt32(id) && u.MovieId == movieId).FirstOrDefault();
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
