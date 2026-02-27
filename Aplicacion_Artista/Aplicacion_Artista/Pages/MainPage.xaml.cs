namespace Aplicacion_Artista.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggledChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Shell.Current.Resources["BackgroundMain"] = Color.FromHex("#90d5ff");
                Shell.Current.Resources["Text"] = Colors.Black;
                Shell.Current.Resources["AccentColor"] = Colors.Black;
                Shell.Current.Resources["SecondaryBackgorund"] = Color.FromHex("#b0d7d7");

                return;
            }

            Shell.Current.Resources["BackgroundMain"] = Color.FromHex("#1a2634");
            Shell.Current.Resources["Text"] = Colors.White;
            Shell.Current.Resources["AccentColor"] = Color.FromHex("#00d2ff");
            Shell.Current.Resources["SecondaryBackgorund"] = Color.FromHex("#283d4f");

            return;
        }
    }
}
