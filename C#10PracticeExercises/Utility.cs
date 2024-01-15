using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10PracticeExercises
{
    public class Utility
    {
        public static int CalculateTotalHoursPerWeek(string averageHoursPerDay)
        {
            int averageHours = int.Parse(averageHoursPerDay);
            int totalHoursPerWeek = averageHours * 7;
            return totalHoursPerWeek;
        }
    }

}

