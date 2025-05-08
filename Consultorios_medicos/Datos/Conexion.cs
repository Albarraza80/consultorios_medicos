using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Consultorios_medicos.Datos
{
    public class Conexion
    {

        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con;

        private Conexion()
        {
            this.Base = "citas_medicas";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "Sisiguaka8#1b36";
        }

        public MySqlConnection CreaConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();

            try
            {
                Cadena.ConnectionString = "server=" + Servidor +
                                        ";port=" + Puerto +
                                        ";user=" + Usuario +
                                        ";password=" + Clave +
                                        ";database=" + Base;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }   
    }
}
