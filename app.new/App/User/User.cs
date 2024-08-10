using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.New.App.User
{
    public class User
    {
        public int ID { get; set; }
        public int Allowed { get; set; }
        public int Admin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

        public User(int ID, int Allowed, int Admin, string Username, string Password, string Email)
        {
            this.ID = ID;
            this.Allowed = Allowed;
            this.Admin = Admin;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.PasswordHash = "";
        }

    }
}
