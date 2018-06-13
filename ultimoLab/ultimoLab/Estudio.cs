using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class Estudio
    {
        public string nombre { get; private set; }
        public string direccion { get; private set; }
        public DateTime fechaApertura { get; private set; }

        public Estudio(string nombre, string direccion, DateTime fechaApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;
        }
    }

}
