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
        await Shell.Current.GoToAsync("..");
    }

}
