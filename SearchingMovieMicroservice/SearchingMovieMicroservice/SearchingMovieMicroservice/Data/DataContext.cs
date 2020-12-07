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
        public DbSet<MovieWithTag> MovieWithTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                ImportMovieDataFromCsv().Take(1000)
            );

            modelBuilder.Entity<MovieWithTag>().HasData(
                ImportMovieTagsDataFromCsv().Take(1000)
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

        public static List<MovieWithTag> ImportMovieTagsDataFromCsv()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMappingTag csvMapper = new CsvMovieDetailsMappingTag();
            CsvParser<MovieWithTag> csvParser = new CsvParser<MovieWithTag>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile("../ML-TestPredML.ConsoleApp/Resources/tag.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            for (int i = 1; i <= result.Count; i++)
            {
                result[i - 1].Id = i;
            }
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

        private class CsvMovieDetailsMappingTag : CsvMapping<MovieWithTag>
        {
            public CsvMovieDetailsMappingTag() : base()
            {
                MapProperty(1, x => x.MovieId);
                MapProperty(2, x => x.Tag);
            }
        }
    }
}
