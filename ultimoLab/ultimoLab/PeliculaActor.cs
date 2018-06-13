using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class PeliculaActor
    {
        public Pelicula pelicula { get; private set; }
        public Actor actor { get; private set; }

        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
    }
}
