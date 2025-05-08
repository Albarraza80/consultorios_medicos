using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorios_medicos.Entidades;
using MySql.Data.MySqlClient;

namespace Consultorios_medicos.Datos
{
    internal class Medico_DAO
    {

        public void Registrar_paciente(P_medico medico)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"INSERT INTO medico (ID_MEDICO, NOMBRE, CONSULTORIO, CORREO, TELEFONO, ID_ESPECIALIDAD) 
                 VALUES (@id_paciente, @nombre, @consultorio, @correo, @telefono, @id_especialidad)";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id_paciente", medico.cedula);
            comando.Parameters.AddWithValue("@nombre", medico.nombre);
            comando.Parameters.AddWithValue("@consultorio", medico.consultorio);
            comando.Parameters.AddWithValue("@correo", medico.correo);
            comando.Parameters.AddWithValue("@telefono", medico.telefono);
            comando.Parameters.AddWithValue("@id_especialidad", medico.especialidad);

            comando.ExecuteNonQuery();
        }

        public P_medico Buscar_medico(int cedula)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"SELECT * FROM medico WHERE ID_MEDICO = @cedula";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cedula", cedula); // int directamente

            using MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return new P_medico
                {
                    cedula = int.Parse(reader["ID_MEDICO"].ToString()),
                    nombre = reader["NOMBRE"].ToString(),
                    correo = reader["CORREO"].ToString(),
                    telefono = reader["TELEFONO"].ToString(),
                    consultorio = int.Parse(reader["CONSULTORIO"].ToString()),
                    especialidad = int.Parse(reader["ID_ESPECIALIDAD"].ToString())
                };
            }

            return null;
        }

        public void Actualizar_medico(P_medico medico)
        {
            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = @"UPDATE medico 
                     SET NOMBRE = @nombre, 
                         CONSULTORIO = @consultorio, 
                         CORREO = @correo, 
                         TELEFONO = @telefono,
                         ID_ESPECIALIDAD = @especialidad
                     WHERE ID_MEDICO = @cedula";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", medico.nombre);
            comando.Parameters.AddWithValue("@consultorio", medico.consultorio);
            comando.Parameters.AddWithValue("@correo", medico.correo);
            comando.Parameters.AddWithValue("@telefono", medico.telefono);
            comando.Parameters.AddWithValue("@especialidad", medico.especialidad);
            comando.Parameters.AddWithValue("@cedula", medico.cedula);

            int filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas == 0)
            {
                throw new Exception("No se encontró el paciente para actualizar.");
            }


        }

        public Dictionary<int, string> ObtenerMedico()
        {
            Dictionary<int, string> medicos = new Dictionary<int, string>();

            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = "SELECT ID_MEDICO, NOMBRE FROM medico";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            using MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID_MEDICO"]);
                string nombre = reader["NOMBRE"].ToString();

                medicos[id] = nombre; // O usar especialidades.Add(id, nombre);
            }

            return medicos;
        }

    }
}
