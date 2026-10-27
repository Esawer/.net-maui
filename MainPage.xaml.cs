namespace _177918
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnProfileClicked(object? sender, EventArgs args)
        {
            await Shell.Current.GoToAsync(nameof(InfoPage));
        }
    }
}
