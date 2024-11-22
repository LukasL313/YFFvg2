using System;
using Npgsql;

namespace ConnectionChecker
{
    public class Connect
    {   
        // Henter kobing string fra Confighelp
        string connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
        
         public async Task CheckConnectionAsync()
         {
            // Kommando for å vise hvilke version av postgres blir brukt, hentet fra DBen
            // Samt hvis fungerer tyder det på at DBen er oppkoblet og funker som normalt. 
             await using (var connection = new NpgsqlConnection(connectionString))
             {
             await connection.OpenAsync();
             Console.WriteLine($"The PostgreSQL version: {connection.PostgreSqlVersion}");
             }
         }
    }
}