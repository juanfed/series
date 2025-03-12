namespace series.Models {
    public class Capitulo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Sinopsis { get; set; }
        public TimeSpan Duration { get; set; }
        public int NumberChapter { get; set; }
        public DateTime StartDate { get; set; }
    }
}