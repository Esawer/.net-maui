using _177918.Models;

namespace _177918;

public partial class TrainingPage : ContentPage
{
    private readonly Training _training = new() { Date = DateTime.Now };

    public TrainingPage()
	{
		InitializeComponent();
        BindingContext = _training;
    }

    private async void OnProfileClicked(object? sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnAddExerciseClicked(object? sender, EventArgs args)
    {
        var name = NameEntry.Text?.Trim();

        if(string.IsNullOrEmpty(name))
        {
            return;
        }

        if(!int.TryParse(SerieEntry.Text, out var series) || !int.TryParse(RepsEntry.Text, out var reps) || !double.TryParse(WeightEntry.Text, out var weight))
        {
            return;
        }

        _training.Exercises.Add(new Exercise
        {
            Number = _training.Exercises.Count + 1,
            ExerciseName = name,
            Series = series,
            Reps = reps,
            Weight = weight
        });

        NameEntry.Text = "";
        SerieEntry.Text = "";
        RepsEntry.Text = "";
        WeightEntry.Text = "";
    }
    private async void OnFinishTrainingClicked(object? sender, EventArgs args)
    {
        TrainingStore.All.Add(_training);
        await Shell.Current.GoToAsync("..");
    }
}