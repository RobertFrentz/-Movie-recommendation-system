﻿namespace MoviesManagementMicroservice.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genres { get; set; }

        public virtual Link Link { get; set; }
    }
}
