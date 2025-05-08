using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;

namespace Consultorios_medicos.Entidades
{
    internal class P_medico
    {

        public int cedula {  get; set; }
        public int especialidad { get; set; }
        public string nombre { get; set; }
        public string correo {  get; set; }
        public int consultorio {  get; set; }
        public string telefono { get; set; }

    }
}
