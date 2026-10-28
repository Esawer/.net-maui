using System.Collections.ObjectModel;
using _177918.Models;

namespace _177918;

public static class TrainingStore
{
    public static ObservableCollection<Training> All { get; } = new(){
    new Training { Date = new DateTime(2026, 11, 18), TrainingName = "Push", Duration = TimeSpan.FromMinutes(45) },
    new Training { Date = new DateTime(2026, 11, 16), TrainingName = "Pull", Duration = TimeSpan.FromMinutes(52) },
    new Training { Date = new DateTime(2026, 11, 14), TrainingName = "Legs", Duration = TimeSpan.FromMinutes(38) },
    new Training { Date = new DateTime(2026, 11, 12), TrainingName = "Cardio", Duration = TimeSpan.FromMinutes(30) },
    new Training { Date = new DateTime(2026, 11, 10), TrainingName = "Full Body", Duration = TimeSpan.FromMinutes(55) },
};
}
