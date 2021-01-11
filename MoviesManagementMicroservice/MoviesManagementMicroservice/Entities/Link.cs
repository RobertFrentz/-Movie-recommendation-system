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
