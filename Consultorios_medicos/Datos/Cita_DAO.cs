using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorios_medicos.Entidades;
using Consultorios_medicos.Presentacion;
using MySql.Data.MySqlClient;

namespace Consultorios_medicos.Datos
{
    internal class Cita_DAO
    {
        public P_cita AgendarCita (P_cita cita){ 
        using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
        conexion.Open();

        string query = @"INSERT INTO cita (ID_MEDICO,ID_PACIENTE,MOTIVO, FECHA, HORA, ESTADO ) 
                 VALUES (@id_medico, @id_paciente, @motivo, @fecha, @hora, @estado)";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id_paciente", cita.Id_Paciente);
            comando.Parameters.AddWithValue("@motivo", cita.Motivo);
            comando.Parameters.AddWithValue("@fecha", cita.Fecha);
            comando.Parameters.AddWithValue("@hora", cita.hora);
            comando.Parameters.AddWithValue("@estado", cita.Estado);
            comando.Parameters.AddWithValue("@id_medico", cita.Id_Medico);

            comando.ExecuteNonQuery();

            return null;

        }

    }
}
