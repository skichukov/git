using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    internal class RoundRepository
    {
        SqlConnection s = new SqlConnection(Properties.Settings.Default.data);
    }
}
