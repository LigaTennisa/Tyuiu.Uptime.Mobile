namespace MauiApp2
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void ToAccount(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Authorization");
        }
        private async void ToTournaments(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TennisLeague");
        }
        private async void ToTrainings(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Coaches");
        }
    }

}
