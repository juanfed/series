

// Instancias con datos de ejemplo
List<Usuario> usuarios = new List<Usuario>
{
    new Usuario { Id = 1, Name = "Juan", LastName = "Pérez", StartRegister = DateTime.Now, Email = "juan@example.com", Password = "123456" },
    new Usuario { Id = 2, Name = "Ana", LastName = "López", StartRegister = DateTime.Now, Email = "ana@example.com", Password = "abcdef" }
};

List<Nombre> nombres = new List<Nombre>
{
    new Nombre { Id = 1, Code = "A001", Name = "Naruto", Type = "anime", Creator = "Masashi Kishimoto" },
    new Nombre { Id = 2, Code = "M001", Name = "Berserk", Type = "manga", Creator = "Kentaro Miura" }
};

List<ListaFavoritos> listasFavoritos = new List<ListaFavoritos>
{
    new ListaFavoritos { Id = 1, IdUser = 1, NameList = "Mis Favoritos", CreatedAt = DateTime.Now, Favoritos = new List<Favorito>
    {
        new Favorito { Id = 1, IdList = 1, Code = "A001", Type = "anime" },
        new Favorito { Id = 2, IdList = 1, Code = "M001", Type = "manga" }
    }}
};