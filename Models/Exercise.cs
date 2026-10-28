using System;
using System.Collections.Generic;
using System.Text;

namespace _177918.Models
{
     public class Exercise
    {
        public int Number { get; set; }
        public string ExerciseName { get; set; } = "";
        public int Series { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
    }
}
