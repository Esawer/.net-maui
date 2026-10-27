namespace _177918
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
            Routing.RegisterRoute(nameof(StatsPage), typeof(StatsPage));
            Routing.RegisterRoute(nameof(TrainingsPage), typeof(TrainingsPage));
            Routing.RegisterRoute(nameof(TrainingsPage), typeof(TrainingsPage));
        }
    }
}
