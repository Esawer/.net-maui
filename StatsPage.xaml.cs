namespace _177918;

public partial class StatsPage : ContentPage
{
	public StatsPage()
	{
		InitializeComponent();
	}

    private async void OnProfileClicked(object? sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("..");
    }
}