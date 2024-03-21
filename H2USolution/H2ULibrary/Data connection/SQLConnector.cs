using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2ULibrary.Models;

namespace H2ULibrary
{
    public class SQLConnector : IDataConnection
    {/// <summary>
     /// SQL connector will send the data back to the database
     /// </summary>
        public ProfileModel CreateProfile(ProfileModel model)
        {
            model.Id = 1;
            return model; 
        }
    }
}
