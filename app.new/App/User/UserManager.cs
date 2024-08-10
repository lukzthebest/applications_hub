using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using Dapper;
using App.New.App.Helper;

namespace App.New.App.User
{
    public class UserManager
    {

        public List<User> users { get; set; }
        public SqlConnection sqlConnection { get; set; }
        public UserManager(SqlConnection sqlConnection) { 
            this.users = sqlConnection.Query<User>("SELECT * FROM Users").ToList();
            this.SqlConnection = sqlConnection;
        }
        public void AddUser(string username, string password)
        {
            var passwordHelper = new PasswordHelper();

            // Hash das Passwort, bevor es gespeichert wird
            string hashedPassword = passwordHelper.HashPassword(password);

            // SQL-Abfrage zum Einfügen eines neuen Benutzers
            string sql = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

            // Verwende Dapper, um die Abfrage auszuführen
            sqlConnection.Execute(sql, new { Username = username, PasswordHash = hashedPassword });
        } 
    }
}
