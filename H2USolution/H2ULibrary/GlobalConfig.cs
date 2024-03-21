using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary
{
    public static class GlobalConfig
    {/// <summary>
     /// this will generalize the data connection
     /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// use it for initializing instances holded by the connection
        /// </summary>
        public static void InitializeConnection()
        {
            SQLConnector sql = new SQLConnector();
            Connection = sql; 
        }
    }
}
