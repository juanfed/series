namespace series.Models {
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime StartRegister { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<ListFavoritos> ListasFavoritos { get; set; } = new();
    }
}