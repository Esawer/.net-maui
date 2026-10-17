namespace _177918
{
    /// <summary>
    /// Root content page of the application.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the tap on the profile icon in the navigation bar.
        /// </summary>
        /// <param name="sender">The image that raised the event.</param>
        /// <param name="args">Event data.</param>
        private async void OnProfileTapped(object? sender, TappedEventArgs args)
        {
            await DisplayAlert("Profil", "Ekran profilu pojawi się tutaj.", "OK");
        }
    }
}
