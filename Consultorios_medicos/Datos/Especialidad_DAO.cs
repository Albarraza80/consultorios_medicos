using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Consultorios_medicos.Datos
{
    internal class Especialidad_DAO
    {
        public Dictionary<int, string> ObtenerEspecialidades()
        {
            Dictionary<int, string> especialidades = new Dictionary<int, string>();

            using MySqlConnection conexion = Conexion.getInstancia().CreaConexion();
            conexion.Open();

            string query = "SELECT ID_ESPECIALIDAD, NOMBRE FROM especialidad";

            using MySqlCommand comando = new MySqlCommand(query, conexion);
            using MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID_ESPECIALIDAD"]);
                string nombre = reader["NOMBRE"].ToString();

                especialidades[id] = nombre; // O usar especialidades.Add(id, nombre);
            }

            return especialidades;
        }

    }
}
