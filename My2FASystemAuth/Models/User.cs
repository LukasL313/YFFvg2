using System;
using BCrypt.Net;

namespace UserAccount
{
    public class UserObject
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        public UserObject(string username, string email, string password) 
        {
            Username = username;
            Email = email;
            Password = password; 
            // midlertidig, inntil jeg lager metoden for å hashe og salte passorde 
        }

        public string hashPassword(Password password)
        {
          string Hashedpassword = BCrypt.Verify(password);
          bool matched = BCrypt.Verify(Hashedpassword, password);
        } 
    }
}