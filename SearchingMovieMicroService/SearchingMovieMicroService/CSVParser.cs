using SearchingMovieMicroService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace SearchingMovieMicroService
{
    public class CSVParser
    {
        private class CsvMovieDetailsMapping : CsvMapping<Movie>
        {
            public CsvMovieDetailsMapping() : base()
            {
                MapProperty(0, x => x.Id);
                MapProperty(1, x => x.Title);
                MapProperty(2, x => x.Genres);
            }
        }
        public static List<float> ImportMovieFromCategorySpecified(string category)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvMovieDetailsMapping csvMapper = new CsvMovieDetailsMapping();
            CsvParser<Movie> csvParser = new CsvParser<Movie>(csvParserOptions, csvMapper);
            List<float> moviesId = new List<float>();
            var movies = csvParser
                         .ReadFromFile("C:/Users/alexg/Source/Repos/SearchingMovieMicroService/SearchingMovieMicroService/movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            Console.WriteLine("MovieId   " + "Title  " + "Genres");
            foreach (var details in movies)
            {
                Console.WriteLine(details.Id + " " + details.Title + " " + details.Genres);
                if(details.Genres.Contains(category))
                {
                    moviesId.Add(details.Id);
                }
            }
            return moviesId;
        }
    }
    
}
