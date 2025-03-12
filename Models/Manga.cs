public class Manga
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Ilustrator { get; set; }
    public string Editorial { get; set; }
    public int Volumes { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}