using Microsoft.EntityFrameworkCore;
using MoviesManagementMicroservice.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace MoviesManagementMicroservice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                ImportMovieDataFromCsv().Take(10000)     // atentie, limitarea numarului de intrari
            );

            var links = ImportLinkDataFromCsv().Take(10000);     // same
            links.ToList().ForEach(l => l.Id = l.MovieId);

            modelBuilder.Entity<Link>().HasData(
                links
            );


            base.OnModelCreating(modelBuilder);
        }

        public static List<Movie> ImportMovieDataFromCsv()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMapping csvMapper = new CsvMovieDetailsMapping();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(@"Files\movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            //Console.WriteLine("MovieId   " + "Title  " + "Genres");
            //foreach (var details in result)
            //{
            //    Console.WriteLine(details.Id + " " + details.Title + " " + details.Genres);
            //}
            return result;
        }

        public static List<Link> ImportLinkDataFromCsv()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvLinkDetailsMapping csvMapper = new CsvLinkDetailsMapping();
            CsvParser<Link> csvParser = new CsvParser<Link>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(@"Files\link.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            //Console.WriteLine("MovieId   " + "ImdbId  " + "TmdbId");
            //foreach (var details in result)
            //{
            //    Console.WriteLine(details.MovieId + " " + details.ImdbId + " " + details.TmdbId);
            //}
            return result;
        }

        private class CsvMovieDetailsMapping : CsvMapping<Movie>
        {
            public CsvMovieDetailsMapping() : base()
            {
                MapProperty(0, x => x.Id);
                MapProperty(1, x => x.Title);
                MapProperty(2, x => x.Genres);
            }
        }

        private class CsvLinkDetailsMapping : CsvMapping<Link>
        {
            public CsvLinkDetailsMapping() : base()
            {
                MapProperty(0, x => x.MovieId);
                MapProperty(1, x => x.ImdbId);
                MapProperty(2, x => x.TmdbId);
            }
        }

    }
}
