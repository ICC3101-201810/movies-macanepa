using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class Pelicula
    {
        public string nombre { get; private set; }
        public Director director { get; private set; }
        public DateTime fechaEstreno { get; private set; }
        public string descripcion { get; private set; }
        public double presupuesto { get; private set; }
        public Estudio estudio { get; private set; }

        public Pelicula(string nombre, Director director, DateTime fechaEstreno, string descripcion, double presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
        }
    }
}
