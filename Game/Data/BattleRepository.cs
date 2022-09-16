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
    internal class BattleRepository
    {
        SqlConnection s = new SqlConnection(Properties.Settings.Default.data);
        Battle latestBattle;

        public void CreateBattle(Battle b)
        {
            s.Open();
            string query = "Insert into Battles ([UserId], [WinnerId], [LoserId], [CreatedDate])" +
                " values(@UserId, @WinnerId, @LoserId, @CreatedDate)";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@UserId", SqlDbType.Int).Value = b.UserId;
            command.Parameters.Add("@WinnerId", SqlDbType.Int).Value = b.Winner.Id;
            command.Parameters.Add("@LoserId", SqlDbType.Int).Value = b.Loser.Id;
            command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = b.CreatedDate;

            object result = command.ExecuteNonQuery();
            s.Close();
        }

        public void SetLatestBattle(Battle b)
        {
            s.Open();
            string query = "Select * from Battles" +
                " where WinnerId = @WinnerId, LoserId = @LoserId, CreatedDate = @CreatedDate";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@WinnerId", SqlDbType.Int).Value = b.WinnerId;
            command.Parameters.Add("@LoserId", SqlDbType.Int).Value = b.LoserId;
            command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = b.CreatedDate;

            SqlDataReader r = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (r.HasRows)
            {
                while (r.Read())
                {
                    latestBattle = new Battle
                    {
                        Id = r.GetInt32(0),
                        UserId = r.GetInt32(1),
                        WinnerId = r.GetInt32(2),
                        LoserId = r.GetInt32(3),
                        CreatedDate = r.GetDateTime(4)
                    };
                }
            }
            s.Close();
        }

        public Battle GetLatestBattle()
        {
            return latestBattle;
        }

        public Battle GetBattleById(int id)
        {
            s.Open();
            string query = "Select [WinnerId], [LoserId], [CreatedDate] from Characters " +
                "where Id = @Id";
            SqlCommand c = new SqlCommand(query, s);
            c.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            SqlDataReader r = c.ExecuteReader(CommandBehavior.CloseConnection);
            if(r.HasRows)
            {
                while(r.Read())
                {
                    Battle b = new Battle
                    {
                        WinnerId = r.GetInt32(0),
                        LoserId = r.GetInt32(1),
                        CreatedDate = r.GetDateTime(2)
                    };

                    r.Close();
                    return b;
                }
            }

            return new Battle();
        }
    }
}
