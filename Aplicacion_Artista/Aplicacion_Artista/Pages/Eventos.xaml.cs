using Aplicacion_Artista.Models;

namespace Aplicacion_Artista.Pages;

public partial class Eventos : ContentPage
{
    private List<Evento> _tours;
    private List<Evento> _eventos;

    /// <summary>
    /// Constructor: Inicializa componentes, carga datos y asigna fuentes.
    /// </summary>
    public Eventos()
    {
        InitializeComponent();
        CargarListas();

        ListaTours.ItemsSource = _tours;
        ListaEventos.ItemsSource = _eventos;
    }

    /// <summary>
    /// Crea y llena las listas con información de giras y eventos.
    /// </summary>
    private void CargarListas()
    {
        _tours = new List<Evento>();
        _eventos = new List<Evento>();

        // Datos de Tours
        _tours.Add(new Evento
        {
            Nombre = "The First World Tour 'Wish'",
            Anio = "2024",
            Imagen = "wish.png",
            Descripcion = "La primera gira mundial masiva, abarcando estadios en Asia, Europa y Estados Unidos."
        });

        _tours.Add(new Evento
        {
            Nombre = "Mars Tour",
            Anio = "2023",
            Imagen = "mars.png",
            Descripcion = "Exitosa gira nacional a través de múltiples arenas y estadios en todo Japón."
        });

        _tours.Add(new Evento
        {
            Nombre = "Shinkiro Tour",
            Anio = "2022-2023",
            Imagen = "shinkiro.png",
            Descripcion = "Segunda gira nacional consolidando su presencia escénica con tecnología avanzada."
        });

        // Datos de Eventos Especiales
        _eventos.Add(new Evento
        {
            Nombre = "Concierto en Budokan 'Campanella'",
            Anio = "2022",
            Imagen = "campanella.png",
            Descripcion = "El legendario primer concierto en vivo en el Budokan, marcando un hito en su carrera."
        });

        _eventos.Add(new Evento
        {
            Nombre = "Saitama Super Arena 'Kyougen'",
            Anio = "2022",
            Imagen = "saitama.png",
            Descripcion = "Presentación especial celebrando el lanzamiento del álbum Kyougen ante miles de fans."
        });

        _eventos.Add(new Evento
        {
            Nombre = "National Stadium 'Shinzou'",
            Anio = "2024",
            Imagen = "shinzou.png",
            Descripcion = "Evento histórico siendo la primera artista femenina solista en llenar el Estadio Nacional."
        });
    }

    /// <summary>
    /// Maneja la selección de un ítem y navega al detalle.
    /// </summary>
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var list = sender as CollectionView;
        if (list?.SelectedItem is Evento eventoSeleccionado)
        {
            await Navigation.PushAsync(new DetalleEvento(eventoSeleccionado));
            list.SelectedItem = null;
        }
    }
}