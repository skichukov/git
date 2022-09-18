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
    internal class HeroeRepository
    {
        SqlConnection s = new SqlConnection(Properties.Settings.Default.data);

        public void CreateHero(Character ch)
        {
            s.Open();
            string query = "Insert into Characters ([UserId], [CharacterName]," +
                " [AttackPoints], [DefencePoints], [HealthPoints], [DateCreated])" +
                " values(@UserId, @CharacterName, @AttackPoints, @DefencePoints," +
                " @HealthPoints, @DateCreated)";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = ch.UserId;
            command.Parameters.Add("@CharacterName", SqlDbType.NVarChar).Value = ch.CharacterName;
            command.Parameters.Add("@AttackPoints", SqlDbType.Int).Value = ch.AttackPoints;
            command.Parameters.Add("@DefencePoints", SqlDbType.Int).Value = ch.DefencePoints;
            command.Parameters.Add("@HealthPoints", SqlDbType.Int).Value = ch.HealthPoints;
            command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = ch.DateCreated;

            object result = command.ExecuteNonQuery();
            s.Close();
        }

        public Character GetHeroById(int id)
        {
            s.Open();
            string query = "Select [CharacterName], [AttackPoints], [DefencePoints]," +
                " [HealthPoints], [DateCreated] from Characters where Id = @Id";
            SqlCommand c = new SqlCommand(query, s);
            c.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            SqlDataReader r = c.ExecuteReader(CommandBehavior.CloseConnection);
            if(r.HasRows)
            {
                while(r.Read())
                {
                    Character ch = new Character()
                    {
                        Id = id,
                        CharacterName = r.GetString(0),
                        AttackPoints = r.GetInt32(1),
                        DefencePoints = r.GetInt32(2),
                        HealthPoints = r.GetInt32(3),
                        DateCreated = r.GetDateTime(4)
                    };

                    r.Close();
                    return ch;
                }
            }

            r.Close();
            return new Character();
        }

        public List<Character> GetUserCharacters(User user)
        {
            List<Character> characters = new List<Character>();
            s.Open();
            string query = "Select [Id], [UserId], [CharacterName]," +
                " [AttackPoints], [DefencePoints], [HealthPoints], [DateCreated]" +
                " from Characters where UserId = @UserId";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.Id;

            SqlDataReader r = command.ExecuteReader(CommandBehavior.CloseConnection);

            if(r.HasRows)
            {
                while(r.Read())
                {
                    Character ch = new Character 
                    {
                       Id = r.GetInt32(0),
                       UserId = r.GetInt32(1),
                       CharacterName = r.GetString(2),
                       AttackPoints = r.GetInt32(3),
                       DefencePoints = r.GetInt32(4),
                       HealthPoints = r.GetInt32(5),
                       DateCreated = r.GetDateTime(6)
                    };

                    characters.Add(ch);
                }
            }

            return characters;
        }

        public void UpdateHero(Character ch)
        {
            s.Open();
            string query = "Update Characters Set CharacterName = @CharacterName," +
                " AttackPoints = @AttackPoints, DefencePoints = @DefencePoints," +
                " HealthPoints = @HealthPoints where Id = @Id";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@CharacterName", SqlDbType.NVarChar).Value = ch.CharacterName;
            command.Parameters.Add("@AttackPoints", SqlDbType.Int).Value = ch.AttackPoints;
            command.Parameters.Add("@DefencePoints", SqlDbType.Int).Value = ch.DefencePoints;
            command.Parameters.Add("@HealthPoints", SqlDbType.Int).Value = ch.HealthPoints;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = ch.Id;

            object result = command.ExecuteNonQuery();
            s.Close();
        }

        public void DeleteHero(int id)
        {
            s.Open();
            string query = "Delete from Characters where Id = @Id";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
            s.Close();
        }
    }
}
