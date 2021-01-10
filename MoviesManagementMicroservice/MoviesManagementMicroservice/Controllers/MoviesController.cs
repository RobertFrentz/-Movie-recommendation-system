using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        // GET: /api/v1/movies/test
        [Route("test")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            var movies = await _context.Movies.Take(15).ToListAsync();
            return await _context.Movies.Take(15).ToListAsync();
        }

        // GET: /api/v1/movies/random
        [Route("random")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetHomeMoviesData()
        {
            List<Movie> movies = _context.Movies.ToList();
            List<int> moviesIds = movies.Select(m => m.Id).OrderBy(i => Guid.NewGuid()).ToList();

            return Ok(moviesIds);
        }

        // GET: /api/v1/movies/moviedata/summary/{movieId}
        [Route("moviedata/summary/{movieId}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDetails>>> GetHomeMovieDataById(int movieId)
        {
            Movie movie = movie = await _context.Movies.FindAsync(movieId);
            if (movie == null)
            {
                return NotFound();
            }
            Link link = await _context.Links.FindAsync(movieId);

            if (link == null)
            {
                Console.WriteLine("Link NOT FOUND");
                return NotFound();
            }

            if (link.ImdbPosterUrl == null)
            {
                string temp = await DataScraping.GetImdbMoviePosterUrlAsync(link.ImdbId);
                link.ImdbPosterUrl = (temp != null) ? temp : null;
            }
            else
            {
                link.ImdbPosterUrl = await DataScraping.GetImdbMoviePosterUrlAsync(link.ImdbId);
            }
            MovieDetails movieDetails = new MovieDetails { Id = movie.Id, Title = movie.Title, Genres = movie.Genres, PosterUrl = link.ImdbPosterUrl };

            await _context.SaveChangesAsync(); // pentru salvarea link-urilor in database

            return Ok(movieDetails);
        }

        // GET: /api/v1/movies/moviedata/complete/{movieId}
        [Route("moviedata/complete/{movieId}")]
        [HttpGet]
        public async Task<ActionResult<string>> GetMovieDataById(int movieId)
        {
            Movie movie = movie = await _context.Movies.FindAsync(movieId);
            if (movie == null)
            {
                return NotFound();
            }

            Link link = await _context.Links.FindAsync(movieId);
            if (link == null)
            {
                Console.WriteLine("Link NOT FOUND");
                return NotFound();
            }

            string json = await DataScraping.GetImdbMovieData(link.ImdbId);
            return Ok(json);
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
