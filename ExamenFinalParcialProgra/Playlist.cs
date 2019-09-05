using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalParcialProgra
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> PeliculasPlaylist { get; set; }

        public Playlist()
        {
            Titulo = "sin nombre";
            Descripcion = "sin registrar";
            PeliculasPlaylist = new List<Peliculas>();

        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            PeliculasPlaylist = new List<Peliculas>();


        }
    }
}
