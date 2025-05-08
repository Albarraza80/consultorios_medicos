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
    public partial class Form_ActualizarPaciente : Form
    {
        public Form_ActualizarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente_DAO paciente_dao = new Paciente_DAO();

            P_paciente paciente = paciente_dao.Buscar_paciente(int.Parse(textBox_CcBuscar.Text));

            if (paciente != null)
            {
                textBox_Apellido.Text = paciente.apellido;
                textBox_Correo.Text = paciente.correo;
                textBox_Nombre.Text = paciente.nombre;
                textBox_Telefono.Text = paciente.telefono;
                dateTimePicker_Nacimiento.Value = paciente.fecha_nacimiento;
            }
            else
            {
                MessageBox.Show("Paciente No existe.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            P_paciente paciente = new P_paciente();
            paciente.Cedula = int.Parse(textBox_CcBuscar.Text);
            paciente.nombre = textBox_Nombre.Text;
            paciente.fecha_nacimiento = dateTimePicker_Nacimiento.Value;
            paciente.apellido = textBox_Apellido.Text;
            paciente.correo = textBox_Correo.Text;
            paciente.telefono = textBox_Telefono.Text;

            Paciente_DAO paciente_dao = new Paciente_DAO();
            paciente_dao.Actualizar_paciente(paciente);

            MessageBox.Show("Paciente Actualizado");

            textBox_Apellido.Text = "";
            textBox_CcBuscar.Text = "";
            textBox_Correo.Text = "";
            textBox_Telefono.Text = "";
            textBox_Nombre.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
