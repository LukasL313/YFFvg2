using System;
using Npgsql;

namespace UserAccount
{  
   public class InsertUser
   { 
      UserObject userobject = new UserObject();

      static async Task InsertingUser(string username, string emai, string password)
      {
        string connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");

        try
        {
           await using (var connection = new NpgsqlConnection(GetConnectionString))
           {
             await connection.OpenAsync();
           
           // Metode for å sette inn data jeg ønsker, opprettelse av bruker i dette tillfelle. 
   
             using (var cmd = new NpgsqlCommand("INSERT INTO user_log_data (\"loginname\",\"emailaddresse\",\"passwordhash\",\"passwordsalt\",) VALUES (@loginname, @emailaddresse, @passwordhash, @passwordsalt)", connection))
             {
                cmd.Parameters.AddWithValue("LoginName", username.loginname);
                cmd.Parameters.AddWithValue("Emailaddresse", email.emailaddresse);  
                cmd.Parameters.AddWithValue("Password", password.passwordhash); 
                cmd.Parameters.AddWithValue("Password", password.passwordsalt); 
             }
           }
        }
        // Errror handling
        catch (System.Exception)
        {
         Console.WriteLine($"Error has occurred: {ex.Message}");
         throw;
        }
      }
   }
}