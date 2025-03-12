using System.Data;
using Npgsql;
using DotNetEnv;

public class PostgreSqlRepository {
    private readonly string _connectionString;

    public PostgreSqlRepository(string connectionString) {

        if(string.IsNullOrEmpty(connectionString)){
            Console.WriteLine("La variable de entorno no puede ser null");
        }

        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection() {
        return new NpgsqlConnection(_connectionString);
    }

    public void TestConnection(){
        using (var conn = CreateConnection()) {
            try{
                conn.Open();
                Console.WriteLine("Se realizó la conección correctamente");
            }catch (Exception e){
                Console.WriteLine($"Error hp: {e.Message}");
            }
        }
    }
}