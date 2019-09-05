using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalParcialProgra
{
    class Peliculas
    {
        public string Titulo { get; set; }
        private int _estreno;
        public int Estreno
        {
            get
            {
                return _estreno;
            }

            set
            {
                if (value >= 1800 && value <= 2019)
                {
                    _estreno = value;
                }
                else
                {
                    throw new Exception("no representa ningun numero valido de estreno");
                }


            }
        }

        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisOrigen { get; set; }
        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("duracion invalida");
                }

            }

        }
        private double _ratingimdb;
        public double RatingIMDB
        {
            get
            {
                return _ratingimdb;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    _ratingimdb = value;
                }

                else
                {
                    throw new Exception("rating invalido");
                }
            }
        }

        public string Sinopsis { get; set; }


        public Peliculas()
        {
            Titulo = "sin registrar";
            Estreno = 1800;
            Director = "sin registrar";
            Genero = "sin registrar";
            PaisOrigen = "sin registrar";
            Duracion = 0;
            RatingIMDB = 0;
            Sinopsis = "sin registrar";
        }

        public Peliculas(string titulo, int estreno, string director, string genero, string paisorigen, int duracion, double ratingimdb, string sinopsis)
        {
            Titulo = titulo;
            Estreno = estreno;
            Director = director;
            Genero = genero;
            PaisOrigen = paisorigen;
            Duracion = duracion;
            RatingIMDB = ratingimdb;
            Sinopsis = sinopsis;
        }

        public Peliculas(string titulo, int estreno)
        {
            Titulo = titulo;
            Estreno = estreno;
        }
    }
}
