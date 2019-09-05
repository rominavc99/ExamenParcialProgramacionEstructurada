using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalParcialProgra
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Peliculas> peliculasplaylist = new List<Peliculas>();
            List<Playlist> playlists = new List<Playlist>();

            Playlist playlist1 = new Playlist("Patio", "Playlist de Peliculas 1");
            playlist1.Titulo = "Home Alone";
            playlist1.Descripcion = "Una playlist de peliculas agradables";


            playlist1.PeliculasPlaylist.Add(new Peliculas("Hola", 1999));
            playlist1.PeliculasPlaylist.Add(new Peliculas("Como estas", 2000));
            playlist1.PeliculasPlaylist.Add(new Peliculas("Muy bien", 2001));
            playlist1.PeliculasPlaylist.Add(new Peliculas("Gatos que vuelan", 1992));
            playlist1.PeliculasPlaylist.Add(new Peliculas("En caso de Morir", 1995));
            playlist1.PeliculasPlaylist.Add(new Peliculas("Im old", 2003));
            playlist1.PeliculasPlaylist.Add(new Peliculas("Kill me now", 2004));

            Playlist playlist2 = new Playlist("Chayanne", "Playlist de Peliculas 2");
            playlist2.Titulo = "Con amigos";
            playlist2.Descripcion = "Una playlist para ver con amigos";

            playlist2.PeliculasPlaylist.Add(new Peliculas("Mis amigos y yo", 1999));
            playlist2.PeliculasPlaylist.Add(new Peliculas("Perros y gatos", 2000));
            playlist2.PeliculasPlaylist.Add(new Peliculas("Las super mascotas", 2001));
            playlist2.PeliculasPlaylist.Add(new Peliculas("Terrbile oremos", 1992));
            playlist2.PeliculasPlaylist.Add(new Peliculas("No he leido lo de diosito", 1995));
            playlist2.PeliculasPlaylist.Add(new Peliculas("Embeces tienes que comerte un anvorguesa y seguir con tu vida", 2003));
            playlist2.PeliculasPlaylist.Add(new Peliculas("Kill me now2", 2004));

            playlists.Add(playlist1);
            playlists.Add(playlist2);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine(" \n * " + " Titulo de la playlist: " + playlist.Titulo + " \n Descripcion de la playlist:" + playlist.Descripcion + "\n");

                foreach (Peliculas peliculas in playlist.PeliculasPlaylist)
                {
                    Console.WriteLine(" - " + "Titulo de la pelicula: " + peliculas.Titulo
                        + " \n Estreno: " + peliculas.Estreno);
                }

            }



            Console.Read();
        }

    }
}

