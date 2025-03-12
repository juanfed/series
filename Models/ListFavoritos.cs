public class ListFavoritos
{
    public int Id { get; set; }
    public int IdUser { get; set; }
    public string NameList { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Favorito> Favoritos { get; set; } = new();
}