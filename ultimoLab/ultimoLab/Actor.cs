using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimoLab
{
    public class Actor : Persona
    {
        public Actor(string nombre, string apellido, DateTime fechaNacimiento, string biografia) : base(nombre, apellido, fechaNacimiento, biografia)
        {
        }
    }
}
