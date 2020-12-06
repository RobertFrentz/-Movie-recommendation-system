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
                         .ReadFromFile("C:/Users/alexg/Source/Repos/SearchingMovieMicroService/SearchingMovieMicroService/Data/movie.csv", Encoding.UTF8)
                         .Select(x => x.Result)
                         .ToList();
            foreach (var details in movies)
            {
                if(details.Genres.Contains(category))
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
                         .ReadFromFile("C:/Users/alexg/Source/Repos/SearchingMovieMicroService/SearchingMovieMicroService/Data/tag.csv", Encoding.UTF8)
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
                         .ReadFromFile("C:/Users/alexg/Source/Repos/SearchingMovieMicroService/SearchingMovieMicroService/Data/movie.csv", Encoding.UTF8)
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
