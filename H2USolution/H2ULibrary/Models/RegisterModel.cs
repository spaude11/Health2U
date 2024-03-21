using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class RegisterModel
    {   /// <summary>
        /// We will verify our username and password in this model for login form
        /// </summary>
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
