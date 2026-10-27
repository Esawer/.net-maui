namespace _177918;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}

    private async void OnProfileClicked(object? sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnStatsClicked(object? sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(StatsPage));
    }

    private async void OnTrainingsClicked(object? sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(TrainingsPage));
    }
}