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
    public partial class Form_AgendarCita : Form
    {
        public Form_AgendarCita()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_cita cita = new P_cita()
            {
                Estado = comboBox_Estado.Text,
                Fecha = dateTimePicker_Fecha.Value,
                Id_Medico = (int)comboBox_Medico.SelectedValue,
                hora = comboBox_Hora.Text,
                Id_Paciente = int.Parse(textBox_Cedula.Text),
                Motivo = textBox_Motivo.Text
            };

            Cita_DAO cita_dao = new Cita_DAO();
            cita_dao.AgendarCita(cita);

            MessageBox.Show("Cita Agendada con Éxito.");

            this.Close();

        }

        private void Form_AgendarCita_Load(object sender, EventArgs e)
        {
            Medico_DAO dao = new Medico_DAO();
            Dictionary<int, string> lista = dao.ObtenerMedico();

            comboBox_Medico.DataSource = new BindingSource(lista, null);
            comboBox_Medico.DisplayMember = "Value";  // Lo que se muestra (nombre)
            comboBox_Medico.ValueMember = "Key";      // El valor asociado (ID)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente_DAO paciente = new Paciente_DAO();
            P_paciente pacienteBuscado = paciente.Buscar_paciente(int.Parse(textBox_Cedula.Text));

            if(pacienteBuscado != null)
            {
                textBox_Nombre.Text = pacienteBuscado.nombre + " " + pacienteBuscado.apellido;
            }
        }
    }
}
