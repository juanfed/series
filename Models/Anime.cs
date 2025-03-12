namespace series.Models {
    public class Anime
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameSeason { get; set; }
        public int Season { get; set; }
        public int NumberChapter { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Capitulo> Capitulos { get; set; } = new();
    }
}