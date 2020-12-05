using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesManagementMicroservice.Entities
{
    public class Link
    {
        public int Id { get; set; }
        public int ImdbId { get; set; }
        public int? TmdbId { get; set; }
        public string ImdbPosterUrl { get; set; }
        public string TmdbPosterUrl { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
