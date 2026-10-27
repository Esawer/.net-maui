namespace _177918;

public partial class TrainingsPage : ContentPage
{
	private bool _allExpanded;

	public TrainingsPage()
	{
		InitializeComponent();
	}

    private async void OnProfileClicked(object? sender, EventArgs args)
    {
        // Pop this page instead of pushing a duplicate instance.
        await Shell.Current.GoToAsync("..");
    }

    private void OnTrainingTapped(object? sender, TappedEventArgs args)
    {
        // Resolve the details label by key from CommandParameter so no x:Reference
        // ordering constraints are needed in XAML.
        var key = args.Parameter?.ToString();
        if (string.IsNullOrEmpty(key))
        {
            return;
        }

        if (this.FindByName<Label>($"Details{key}") is Label details)
        {
            details.IsVisible = !details.IsVisible;
        }
    }

    private void OnToggleAllTapped(object? sender, TappedEventArgs args)
    {
        _allExpanded = !_allExpanded;
        DetailsMonday.IsVisible = _allExpanded;
        DetailsWednesday.IsVisible = _allExpanded;
        DetailsFriday.IsVisible = _allExpanded;
        DetailsSaturday.IsVisible = _allExpanded;
    }
}
