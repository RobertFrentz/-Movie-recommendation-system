using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchingMovieMicroservice.Entities
{
    public class MovieWithTag
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public string Tag { get; set; }
    }
}
