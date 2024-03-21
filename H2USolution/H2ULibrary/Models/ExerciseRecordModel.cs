using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class ExerciseRecordModel
    {
        /// <summary>
        /// We will create model for exercise records and validate information
        /// </summary>
        public int Id { get; set; }
        public float Weight { get; set; }

        public string WaterIntake { get; set; }
        public string ExerciseDay { get; set; }
        public string CaloriesBurnt { get; set; }
        public string Comments { get; set; }


        /// <summary>
        /// We will create the list for exercise record to compare with user's goal
        /// </summary>
        public List<ExerciseRecordModel> ExerciseRecord { get; set; } = new List<ExerciseRecordModel>();
        /// We will validate all the information here and send information to database

    }
}
