using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorios_medicos.Entidades;
using MySql.Data.MySqlClient;

namespace Consultorios_medicos.Datos
{
    internal class Paciente_DAO
    {
        public void Registrar_paciente(P_paciente paciente)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"INSERT INTO paciente (`ID_PACIENTE`,`NOMBRE`,`APELLIDO`,`CORREO`,`TELEFONO`,`FECHA_NACIMIENTO`) 
                                 VALUES (@id_paciente, @nombre, @apellido, @correo, @telefono, @fecha_nacimiento)";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id_paciente", paciente.Cedula);
            comando.Parameters.AddWithValue("@nombre", paciente.nombre);
            comando.Parameters.AddWithValue("@apellido", paciente.apellido);
            comando.Parameters.AddWithValue("@correo", paciente.correo);
            comando.Parameters.AddWithValue("@telefono", paciente.telefono);
            comando.Parameters.AddWithValue("@fecha_nacimiento", paciente.fecha_nacimiento.Date);

            comando.ExecuteNonQuery();
        }

        public P_paciente Buscar_paciente(int cedula)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"SELECT * FROM paciente WHERE ID_PACIENTE = @cedula";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cedula", cedula); // int directamente

            using MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return new P_paciente
                {
                    Cedula = int.Parse(reader["ID_PACIENTE"].ToString()),
                    nombre = reader["NOMBRE"].ToString(),
                    correo = reader["CORREO"].ToString(),
                    telefono = reader["TELEFONO"].ToString(),
                    apellido = reader["APELLIDO"].ToString(),
                    fecha_nacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"])
                };
            }

            return null;
        }

        public void Actualizar_paciente(P_paciente paciente)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"UPDATE paciente 
                     SET NOMBRE = @nombre, 
                         APELLIDO = @apellido, 
                         CORREO = @correo, 
                         TELEFONO = @telefono,
                         FECHA_NACIMIENTO = @fecha_nacimiento
                     WHERE ID_PACIENTE = @cedula";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", paciente.nombre);
            comando.Parameters.AddWithValue("@apellido", paciente.apellido);
            comando.Parameters.AddWithValue("@correo", paciente.correo);
            comando.Parameters.AddWithValue("@telefono", paciente.telefono);
            comando.Parameters.AddWithValue("@fecha_nacimiento", paciente.fecha_nacimiento);
            comando.Parameters.AddWithValue("@cedula", paciente.Cedula);

            int filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas == 0)
            {
                throw new Exception("No se encontró el paciente para actualizar.");
            }


        }
    }
}
