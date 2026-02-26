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
                Shell.Current.Resources["PrimaryColor"] = Color.FromHex("#00d2ff");
                return;
            }

            Shell.Current.Resources["PrimaryColor"] = Color.FromHex("#1a2634");
            return;
        }
    }
}
