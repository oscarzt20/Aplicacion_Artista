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

                return;
            }

            Shell.Current.Resources["BackgroundMain"] = Color.FromHex("#1a2634");
            Shell.Current.Resources["Text"] = Colors.White;

            return;
        }
    }
}
