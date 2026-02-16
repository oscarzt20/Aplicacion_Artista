using Aplicacion_Artista.Models;

namespace Aplicacion_Artista.Pages;

public partial class DetalleEvento : ContentPage
{
    /// <summary>
    /// Constructor: Recibe el objeto Evento y lo asigna al BindingContext.
    /// </summary>
    public DetalleEvento(Evento eventoSeleccionado)
    {
        InitializeComponent();
        BindingContext = eventoSeleccionado;
    }
}