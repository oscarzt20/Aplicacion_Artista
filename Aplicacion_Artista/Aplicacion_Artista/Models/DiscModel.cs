using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_Artista.Models
{
    /// <summary>
    /// Modelos para la discografia y los detalles de esta
    /// </summary>
    public class DiscModel
    {
        public string imagen { get; set; } = string.Empty;
        public string NombreAlbum { get; set; } = string.Empty;
        public string Año { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
}
