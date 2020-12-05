using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagementMicroservice.Entities
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genres { get; set; }
        public string PosterUrl { get; set; }
    }
}
