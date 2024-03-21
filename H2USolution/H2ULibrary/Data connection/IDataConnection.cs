using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2ULibrary.Models;

namespace H2ULibrary
{
    /// <summary>
    /// interface will define the properties, method and events that class will implement
    /// </summary>
    public interface IDataConnection
    {
        ProfileModel CreateProfile(ProfileModel model);
    }
}
