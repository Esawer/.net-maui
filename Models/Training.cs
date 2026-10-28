using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace _177918.Models
{
     public class Training
    {
        public DateTime Date { get; set; }
        public string TrainingName { get; set; } = "";
        public string AdditionalText { get; set; } = "";
        public TimeSpan Duration { get; set; }
        public ObservableCollection<Exercise> Exercises { get; } = new();
    }
}
