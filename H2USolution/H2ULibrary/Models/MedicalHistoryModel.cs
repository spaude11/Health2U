using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class MedicalHistoryModel
    {
        /// <summary>
        /// We will setup the model for our medical history where we will validate all the information
        /// </summary>
        public int Id { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string lifeStyle { get; set; }
        public string BloodSugar { get; set; }

        public string BMI { get; set; }

        public string Diseases { get; set; }
        public string Drugs { get; set; }
        public string Checkups { get; set; }

        /// We will validate information in this section  


    }
}
