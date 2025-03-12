var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres";
var repository = new PostgreSqlRepository(connectionString);
repository.TestConnection();