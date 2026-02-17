using Aplicacion_Artista.Models;
using System.Xml;

namespace Aplicacion_Artista.Pages;


/// <summary>
/// Muestra una pagina con el detalle del album seleccionado
/// </summary>
[QueryProperty(nameof(DiscModel), "Discografia")]

public partial class DiscografiaDetail : ContentPage
{
	private DiscModel _discModel;

    public DiscModel DiscModel
    {
        set
        {
            _discModel = value;
        }
    }
    public DiscografiaDetail()
	{
		InitializeComponent();
        _discModel = new DiscModel();
    }

    /// <summary>
    /// Muestra los detalles dependiendo la discografia
    /// </summary>
    override protected void OnAppearing()
    {
        base.OnAppearing();
        albumImage.Source = _discModel.imagen;
        albumLabel.Text = _discModel.NombreAlbum;
        añoLabel.Text = _discModel.Año;
        descripcionLabel.Text = _discModel.Descripcion;
    }
}