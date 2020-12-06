
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace ML_TestPredML.ConsoleApp
{
    public class CSVParser
    {
        private class Movie
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Genres { get; set; }

            public string Tag { get; set; }
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

        private class CsvMovieDetailsMappingTag : CsvMapping<Movie>
        {
            public CsvMovieDetailsMappingTag() : base()
            {
                MapProperty(1, x => x.Id);
                MapProperty(2, x => x.Tag);
            }
        }

        public static List<float> ImportMovieFromCategorySpecified(string category)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMapping csvMapper = new CsvMovieDetailsMapping();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            List<float> moviesId = new List<float>();
            var movies = csvParser
                         .ReadFromFile("../ML-TestPredML.ConsoleApp/Resources/movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            foreach (var details in movies)
            {
                if (details.Genres.Contains(category))
                {
                    moviesId.Add(details.Id);
                }
            }
            return moviesId;
        }
        public static List<float> ImportMovieFromTagSpecified(string tag)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMappingTag csvMapper = new CsvMovieDetailsMappingTag();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            List<float> moviesId = new List<float>();
            var movies = csvParser
                         .ReadFromFile("../ML-TestPredML.ConsoleApp/Resources/tag.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            foreach (var details in movies)
            {
                if (details.Tag.Contains(tag) || tag.Contains(details.Tag))
                {
                    //Console.WriteLine("MovieId: " + details.Id);
                    moviesId.Add(details.Id);
                }
            }
            return moviesId;
        }
        public static List<float> ImportMovieFromTitleSpecified(string title)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMapping csvMapper = new CsvMovieDetailsMapping();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            List<float> moviesId = new List<float>();
            var movies = csvParser
                         .ReadFromFile("../ML-TestPredML.ConsoleApp/Resources/movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            foreach (var details in movies)
            {

                if (details.Title.Contains(title))
                {
                    moviesId.Add(details.Id);
                }
            }
            return moviesId;
        }
    }

}
