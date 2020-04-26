using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićTournamentTracker
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database,bool textFiles)
        {
            if (database)
            {
                //Stvoriti SQL veza
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //Stvoriti text veza
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
