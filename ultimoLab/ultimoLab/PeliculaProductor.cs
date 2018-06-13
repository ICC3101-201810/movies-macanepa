using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class PeliculaProductor
    {
        public Pelicula pelicula { get; private set; }
        public Productor productor { get; private set; }

        public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
