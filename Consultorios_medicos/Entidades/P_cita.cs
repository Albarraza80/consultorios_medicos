using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorios_medicos.Entidades
{
    internal class P_cita
    {
        public int Id_Paciente {  get; set; }
        public int Id_Medico {  get; set; }
        public string Motivo {  get; set; }
        public string Estado {  get; set; }
        public DateTime Fecha {  get; set; }
        public string hora {  get; set; }

    }
}
