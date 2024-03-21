using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class ProfileModel
    {   /// <summary>
        /// We will create our profile variable here. 
        /// </summary>
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
        /// <summary>
        /// CellPhone Number cannot be added as math number
        /// </summary>
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Area { get; set; }


    }
}
