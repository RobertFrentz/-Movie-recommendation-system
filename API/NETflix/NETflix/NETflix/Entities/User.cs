using NETflix.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETflix.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string Preference { get; set; }

    }
}
