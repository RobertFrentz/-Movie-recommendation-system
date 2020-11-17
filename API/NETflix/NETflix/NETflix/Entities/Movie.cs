using NETflix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETflix.Entities
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }

        public string MovieDescription { get; set; }

        public string Genre { get; set; }

    }
}
