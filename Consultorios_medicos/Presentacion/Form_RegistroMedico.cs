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
    public partial class Form_RegistroMedico : Form
    {
        public Form_RegistroMedico()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_RegistrarMedico_Click(object sender, EventArgs e)
        {
            P_medico medico = new P_medico
            {
                cedula = int.Parse(textBox_Cedula.Text),
                nombre = textBox_Nombre.Text,
                correo = textBox_Correo.Text,
                especialidad = (int)comboBox_Especialidad.SelectedValue,
                consultorio = int.Parse(textBox_Consultorio.Text),
                telefono = textBox_Telefono.Text
            };

            Medico_DAO medico_DAO = new Medico_DAO();
            medico_DAO.Registrar_paciente(medico);

            MessageBox.Show("Médico Registrado.");

            this.Close();

        }

        private void Form_RegistroMedico_Load(object sender, EventArgs e)
        {
            Especialidad_DAO dao = new Especialidad_DAO();
            Dictionary<int, string> lista = dao.ObtenerEspecialidades();

            comboBox_Especialidad.DataSource = new BindingSource(lista, null);
            comboBox_Especialidad.DisplayMember = "Value";  // Lo que se muestra (nombre)
            comboBox_Especialidad.ValueMember = "Key";      // El valor asociado (ID)
        }

        private void comboBox_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
