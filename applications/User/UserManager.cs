using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace applications.User
{
    internal class UserManager
    {
        public List<User> Users { get; }
        public UserManager() { 
            this.Users = new List<User>();
            this.InitUsers();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public void InitUsers()
        {
            this.Users.Clear();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // kann noch besser gemacht werden
                    string query = "SELECT * FROM Users";

                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(Convert.ToInt32(reader["ID"]),
                                                 Convert.ToInt32(reader["Allowed"]),
                                                 Convert.ToInt32(reader["Admin"]),
                                                 reader["Username"].ToString(),
                                                 reader["Password"].ToString(),
                                                 reader["Email"].ToString()
                                                 );
                            this.AddUser(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler bei der Verbindung: " + ex.Message);
                }
            }
        }

        public void UpdateUserStatus(int id, bool doit, int status)
        {
            //STATUS = 0 = admin
            //         1 = allowed
            string query = "";
            switch (status)
            {
                case 0:
                    query = "UPDATE Users SET Admin = @value1 WHERE ID = @condition";
                    break;
                case 1:
                    query = "UPDATE Users SET Allowed = @value1 WHERE ID = @condition";
                    break;
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int doityes = 0;
                        if (doit)
                        {
                            doityes = 1;
                        }
                        else
                        {
                            doityes = 0;
                        }
                        command.Parameters.AddWithValue("@value1", doityes);
                        command.Parameters.AddWithValue("@condition", id);

                        // Abfrage ausführen und die Anzahl der betroffenen Zeilen erhalten
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Fehlerbehandlung
                    MessageBox.Show($"Fehler: {ex.Message}");
                }
            }
        }

        public void ClearAndReloadUsers()
        {
            this.InitUsers();
        }

        public void AddUser(User user)
        {
            this.Users.Add(user);
        }
    }
}
