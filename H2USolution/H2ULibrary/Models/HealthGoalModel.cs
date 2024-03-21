using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ULibrary.Models
{
    public class HealthGoalModel
    { /// We will create model for healthgoal and validate information. 
        public int Id { get; set; }
        public string WeightGoal { get; set; }

        public string WaterIntakeGoal { get; set; }
        public string ExerciseDaysGoal { get; set; }
        public string CaloriesBurnGoal { get; set; }



        /// we will validate all the information here and create goal list in a TextBox 
        public List<HealthGoalModel> HealthGoal { get; set; } = new List<HealthGoalModel>();

    }
}
