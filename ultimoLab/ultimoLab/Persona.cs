using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class Persona
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public DateTime fechaNacimiento { get; private set; }
        public string biografia { get; private set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.biografia = biografia;
        }
    }
}
