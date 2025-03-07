// Entidad principal: Nombre
public class Nombre
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string AnotherNames { get; set; }
    public string Creator { get; set; }
    public string Genres { get; set; }
    public string Type { get; set; } // anime, manga, pelicula, libro
}

// Entidad Anime
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

// Entidad Pelicula
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

// Entidad Manga
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

// Entidad Libro
public class Libro
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Ilustrator { get; set; }
    public string Editorial { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
}

// Entidad Capitulo
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

// Entidad Usuario
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

// Lista de favoritos
public class ListFavoritos
{
    public int Id { get; set; }
    public int IdUser { get; set; }
    public string NameList { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Favorito> Favoritos { get; set; } = new();
}

// Relación de favoritos
public class Favorito
{
    public int Id { get; set; }
    public int IdList { get; set; }
    public string Code { get; set; }
    public string Type { get; set; } // anime, manga, pelicula, libro
}

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