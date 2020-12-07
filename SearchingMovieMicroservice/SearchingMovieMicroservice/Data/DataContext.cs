using Microsoft.EntityFrameworkCore;
using SearchingMovieMicroservice.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace SearchingMovieMicroservice.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                ImportMovieDataFromCsv().Take(1000)
            );

            base.OnModelCreating(modelBuilder);
        }

        public static List<Movie> ImportMovieDataFromCsv()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMapping csvMapper = new CsvMovieDetailsMapping();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile("../ML-TestPredML.ConsoleApp/Resources/movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
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
    }
}
