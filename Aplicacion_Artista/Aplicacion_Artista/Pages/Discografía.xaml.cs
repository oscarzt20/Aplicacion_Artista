using Aplicacion_Artista.Models;

namespace Aplicacion_Artista.Pages;

public partial class Discografía : ContentPage
{
    private List<DiscModel> _discografias = [

        new()  { imagen = "https://m.media-amazon.com/images/I/61dBDC8tyBL._UF1000,1000_QL80_.jpg", NombreAlbum = "Zanmu", Año = "2024", Descripcion = "\"Zanmu\" es una palabra real que significa \"un sueño incumplido\" o un sueño que persiste incluso después de despertar. es el segundo álbum de estudio de la cantante japonesa Ado, lanzado en julio de 2024. Incluye éxitos como \"Show\" y \"Kura Kura\", destacando por su estilo J-Pop y colaboraciones"},
        new()  { imagen = "https://m.media-amazon.com/images/I/61orA6aSyiL._AC_UF1000,1000_QL80_.jpg", NombreAlbum = "Ado's utattemita", Año = "2023", Descripcion = "Ado's Utattemita Album (Adoの歌ってみたアルバム), lanzado el 13 de diciembre de 2023 por Universal Music, es el primer álbum de versiones (covers) de la cantante japonesa Ado, alcanzando el puesto n.º 2 en Oricon. Incluye 10 canciones populares de Vocaloid y J-Pop, votadas por fans, que abarcan desde la era Showa hasta Reiwa, destacando su versatilidad. "},
        new()  { imagen = "https://m.media-amazon.com/images/I/81d0YH86DJL._UF1000,1000_QL80_.jpg", NombreAlbum = "Kyōgen", Año = "2022", Descripcion = " Kyōgen se traduce como \"palabras locas\" o \"discurso salvaje\", haciendo referencia al teatro cómico tradicional japonés del mismo nombre. Kyōgen (狂言) es el álbum de estudio debut de la cantante japonesa Ado, lanzado el 26 de enero de 2022. Este disco de J-pop y rock, producido por varios músicos de Vocaloid, alcanzó el número uno en las listas de Oricon y Billboard Japan. Presenta canciones enérgicas y líricas intensas, incluyendo éxitos como \"Usseewa\". "},
        new()  { imagen = "https://cdn-images.dzcdn.net/images/cover/4227788fb6557a65945db73e2bbd4bbe/0x1900-000000-80-0-0.jpg", NombreAlbum = "Uta's songs: one piece film red", Año = "2024", Descripcion = "Incluye 7 canciones principales y temas especiales, interpretados por Ado como la voz cantante de Uta en la película One Piece Film: Red. El álbum debutó número 1 en Billboard Japan y presenta colaboraciones con productores destacados como Yasutaka Nakata, Vaundy, Mrs. GREEN APPLE, entre otros, mezclando J-Pop, rock y baladas para reflejar la evolución emocional de la protagonista. "},

    ];

    private List<DiscModel> _filteredDiscografias;

    public Discografía()
	{
		InitializeComponent();
        _filteredDiscografias = [.. _discografias];
        discografiasList.ItemsSource = _filteredDiscografias;
    }

    private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is DiscModel selectedDiscografia)
        {
            await Shell.Current.GoToAsync(nameof(DiscografiaDetail), new Dictionary<string, object>
            {
                { "Discografia", selectedDiscografia }
            });

            discografiasList.SelectedItem = null;
        }
    }
}