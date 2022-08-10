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
        string data = "Data Source=STILI\\SQLEXPRESS;Initial Catalog=GameDb;Integrated Security=True";

        public void CreateUser(User user)
        {
            SqlConnection s = new SqlConnection(data);
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

        public User GetUserById(int id)
        {
            SqlConnection s = new SqlConnection(data);
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
        }

        
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            SqlConnection s = new SqlConnection(data);
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
        
    }
}
