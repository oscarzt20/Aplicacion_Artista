namespace Aplicacion_Artista
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pages.Discografía), typeof(Pages.Discografía));
            Routing.RegisterRoute(nameof(Pages.DiscografiaDetail), typeof(Pages.DiscografiaDetail));
        }
    }
}
