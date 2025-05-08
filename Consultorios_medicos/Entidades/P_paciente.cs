using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorios_medicos.Entidades
{
    internal class P_paciente
    {

        public int Cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; }

    }
}
