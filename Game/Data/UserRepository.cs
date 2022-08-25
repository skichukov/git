using Game.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    internal class UserRepository
    {
        SqlConnection s = new SqlConnection(Properties.Settings.Default.data);
        User loggedUser;

        public void CreateUser(User user)
        {
            s.Open();
            string query = "Insert into Users ([Name], [Username], [Password], [DateCreated])" +
                " values(@Name, @Username, @Password, @DateCreated)";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
            command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
            command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = user.DateCreated;

            object result = command.ExecuteNonQuery();
        }

        internal void SaveUser(User user)
        {
            s.Open();
            string query = "Select * from Users" +
                " where Username = @Username and Password = @Password";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;

            SqlDataReader r = command.ExecuteReader(CommandBehavior.CloseConnection);
            if(r.HasRows)
            {
                while(r.Read())
                {
                    loggedUser = new User
                    {
                        Id = r.GetInt32(0),
                        Name = r.GetString(1),
                        Username = r.GetString(2),
                        Password = r.GetString(3),
                        DateCreated = r.GetDateTime(4)
                    };
                }
            }
            s.Close();
        }

        public User GetCurrentUser()
        {
            return loggedUser;
        }

        public bool HasUserWith(string username, string password)
        {
            //s.Open();
            string query = "Select [Name], [Username], [Password], [DateCreated] from Users" +
                " where Username = @Username and Password = @Password";
            SqlDataAdapter sda = new SqlDataAdapter(query, s);
            sda.SelectCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            sda.SelectCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public User GetUserById(int id)
        {
            s.Open();
            string query = "Select [Name], [Username], [Password], [DateCreated] from Users" +
                " where Id = @Id";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    User user = new User()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Username = reader.GetString(2),
                        Password = reader.GetString(3),
                        DateCreated = reader.GetDateTime(4)
                    };

                    return user;
                }
            }

            return new User();
            s.Close();
        }

        
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            s.Open();
            string query = "Select [Name], [Username], [Password], [DateCreated] from Users";
            SqlCommand command = new SqlCommand(query, s);
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    User user = new User
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Username = reader.GetString(2),
                        Password = reader.GetString(3),
                        DateCreated = reader.GetDateTime(4)
                    };

                    users.Add(user);
                }
            }

            return users;
        }

        public void UpdateUser(User user)
        {
            s.Open();
            string query = "Update Users Set Name = @Name, Username = @Username, Passsword = "
                + "@Password where Id = @Id";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
            command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;

            object result = command.ExecuteNonQuery();
            s.Close();
        }
        
    }
}
