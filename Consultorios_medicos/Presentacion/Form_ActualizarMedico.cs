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
    public partial class Form_ActualizarMedico : Form
    {
        public Form_ActualizarMedico()
        {
            InitializeComponent();
        }

        private void Form_ActualizarMedico_Load(object sender, EventArgs e)
        {
            Especialidad_DAO dao = new Especialidad_DAO();
            Dictionary<int, string> lista = dao.ObtenerEspecialidades();

            comboBox_Especialidad.DataSource = new BindingSource(lista, null);
            comboBox_Especialidad.DisplayMember = "Value";  // Lo que se muestra (nombre)
            comboBox_Especialidad.ValueMember = "Key";      // El valor asociado (ID)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico_DAO medico_DAO = new Medico_DAO();
            P_medico medico = medico_DAO.Buscar_medico(int.Parse(textBox_Cedula.Text));

            if (medico != null)
            {
                textBox_Consultorio.Text = medico.consultorio.ToString();
                textBox_Correo.Text = medico.correo;
                textBox_Nombre.Text = medico.nombre;
                textBox_Telefono.Text = medico.telefono;
                comboBox_Especialidad.Text = "";

            }
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
         
            P_medico medico = ObtenerMedicoDesdeFormulario();

            Medico_DAO medico_DAO = new Medico_DAO();
            medico_DAO.Actualizar_medico(medico);

            MessageBox.Show("Médico Actualizado");

            LimpiarFormulario();

        }

        private void comboBox_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
