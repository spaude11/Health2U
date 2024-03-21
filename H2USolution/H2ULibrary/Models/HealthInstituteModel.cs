using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class HealthInstituteModel
    {
        /// <summary>
        /// We will setup the model for our health Institution where we will validate all the information. We will ask if the person lives in shreveport or dallas and provide user with the list of health institutes near the locality
        /// </summary>
        public int Id { get; set; }
        public string AreaName { get; set; }
        /// <summary>
        /// list of health institutes we will add on our web application.
        /// </summary>
        public string InstituteName { get; set; }
        public string InstituteAddress { get; set; }
        public string InstitutePhoneNo { get; set; }
        public string WebsiteAddress { get; set; }
        public string ZipCode { get; set; }
        public List<HealthInstituteModel> Institute { get; set; } = new List<HealthInstituteModel>();

    }
}

