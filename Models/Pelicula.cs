namespace series.Models {
    public class Pelicula
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameMovie { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartDate { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
    }
}