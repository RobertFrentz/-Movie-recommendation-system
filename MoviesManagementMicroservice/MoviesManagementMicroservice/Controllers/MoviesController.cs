using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesManagementMicroservice.Data;
using MoviesManagementMicroservice.Entities;
using MoviesManagementMicroservice.Utils;

namespace MoviesManagementMicroservice.Controllers
{
    [Route("api/v1/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;

        public MoviesController(DataContext context)
        {
            _context = context;
        }


        // GET: /api/v1/movies/random
        [Route("random")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetRandomMoviesIds()
        {
            List<Movie> movies = await _context.Movies.ToListAsync();
            List<int> moviesIds = movies.Select(m => m.Id).OrderBy(i => Guid.NewGuid()).ToList();

            return Ok(moviesIds);
        }

        // GET: /api/v1/movies/moviedata/summary/{movieId}
        [Route("moviedata/summary/{movieId}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDetails>>> GetSummaryMovieDataById(int movieId)
        {
            Movie movie = await _context.Movies.FindAsync(movieId);
            if (movie == null)
            {
                return NotFound();
            }
            Link link = await _context.Links.FindAsync(movieId);

            if (link == null)
            {
                return NotFound();
            }

            if (link.ImdbPosterUrl == null)
            {
                string temp = await DataScraping.GetImdbMoviePosterUrlAsync(link.ImdbId);
                link.ImdbPosterUrl = (temp != null) ? temp : null;
            }

            MovieDetails movieDetails = new MovieDetails { Id = movie.Id, Title = movie.Title, Genres = movie.Genres, PosterUrl = link.ImdbPosterUrl };

            _context.Update(link);
            _context.SaveChanges(); // pentru salvarea link-uri postere

            return Ok(movieDetails);
        }

        // GET: /api/v1/movies/moviedata/complete/{movieId}
        [Route("moviedata/complete/{movieId}")]
        [HttpGet]
        public async Task<ActionResult<string>> GetMovieDataById(int movieId)
        {
            Movie movie = await _context.Movies.FindAsync(movieId);
            if (movie == null)
            {
                return NotFound();
            }

            Link link = await _context.Links.FindAsync(movieId);
            if (link == null)
            {
                return NotFound();
            }

            string json = await DataScraping.GetImdbMovieData(link.ImdbId);
            return Ok(json);
        }

    }
}
