using Consultorios_medicos.Datos;
using Consultorios_medicos.Entidades;
using Consultorios_medicos.Presentacion;

namespace Consultorios_medicos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Principal());
        }
    }
}