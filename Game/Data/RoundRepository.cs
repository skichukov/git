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
    internal class RoundRepository
    {
        SqlConnection s = new SqlConnection(Properties.Settings.Default.data);

        public void CreateRound(Round r)
        {
            s.Open();
            string query = "Insert into Rounds ([BattleId], [Character1State], " +
                "[Character2State], [RoundIndex], [RandomNumber], [DateCreated]) " +
                "values(@BattleId, @Character1State, @Character2State, @RoundIndex, " +
                "@RandomNumber, @DateCreated)";
            SqlCommand command = new SqlCommand(query, s);
            command.Parameters.Add("@BattleId", SqlDbType.Int).Value = r.BattleId;
            command.Parameters.Add("@Character1State", SqlDbType.Int).Value = r.Character1State;
            command.Parameters.Add("@Character2State", SqlDbType.Int).Value = r.Character2State;
            command.Parameters.Add("@RoundIndex", SqlDbType.Int).Value = r.RoundIndex;
            command.Parameters.Add("@RandomNumber", SqlDbType.Int).Value = r.RandomNumber;
            command.Parameters.Add("@DateCreated", SqlDbType.DateTime).Value = r.DateCreated;

            object result = command.ExecuteNonQuery();
            s.Close();
        }
    }
}
