using System;

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
        }
    }
}