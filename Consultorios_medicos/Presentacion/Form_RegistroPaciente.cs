using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorios_medicos.Datos;
using Consultorios_medicos.Entidades;

namespace Consultorios_medicos.Presentacion
{
    public partial class Form_RegistroPaciente : Form
    {
        public Form_RegistroPaciente()
        {
            InitializeComponent();
        }

        private void button_RegistrarPaciente_Click(object sender, EventArgs e)
        {
            P_paciente paciente = new P_paciente
            {
                Cedula = int.Parse(textBox_Cedula.Text),
                nombre = textBox_Nombre.Text,
                correo = textBox_Correo.Text,
                apellido = textBox_Apellido.Text,
                fecha_nacimiento = dateTime_Nacimiento.Value,
                telefono = textBox_Telefono.Text
            };

            Paciente_DAO paciente_dao = new Paciente_DAO();
            paciente_dao.Registrar_paciente(paciente);

            MessageBox.Show("Paciente Registrado.");

            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
