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
            string query = "Insert into Characters ([UserId], [CharacterName], [TYPE]," +
                " [AttackPoints], [DefencePoints], [HealthPoints], [DateCreated])" +
                " values(@UserId, @CharacterName, @TYPE, @AttackPoints, @DefencePoints," +
                " @HealthPoints, @DateCreated)";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = ch.UserId;
            command.Parameters.Add("@CharacterName", SqlDbType.NVarChar).Value = ch.CharacterName;
            command.Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = ch.Type;
            command.Parameters.Add("@AttackPoints", SqlDbType.Int).Value = ch.AttackPoints;
            command.Parameters.Add("@DefencePoints", SqlDbType.Int).Value = ch.DefencePoints;
            command.Parameters.Add("@HealthPoints", SqlDbType.Int).Value = ch.HealthPoints;
            command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = ch.DateCreated;

            object result = command.ExecuteNonQuery();
            s.Close();
        }
    }
}
