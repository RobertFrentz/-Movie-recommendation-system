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
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;

        public MoviesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            var movies = await _context.Movies.Take(15).ToListAsync();
            return await _context.Movies.Take(15).ToListAsync();
        }

        // GET: api/MoviesDetails
        [Route("HomeMoviesData")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetHomeMoviesData()
        {
            List<Movie> movies = _context.Movies.ToList();
            List<int> moviesIds = movies.Select(m => m.Id).ToList();

            return Ok(moviesIds);
        }

        [Route("HomeMoviesData/{movieId}")]
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
                link.ImdbPosterUrl = await DataScraping.GetImdbMoviePosterUrlAsync(link.ImdbId);
            }
            else
            {
                link.ImdbPosterUrl = await DataScraping.GetImdbMoviePosterUrlAsync(link.ImdbId);
            }
            MovieDetails movieDetails = new MovieDetails { Id = movie.Id, Title = movie.Title, Genres = movie.Genres, PosterUrl = link.ImdbPosterUrl };

            await _context.SaveChangesAsync(); // pentru salvarea link-urilor in database

            return Ok(movieDetails);
        }

        [Route("MoviesData/{movieId}")]
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

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
