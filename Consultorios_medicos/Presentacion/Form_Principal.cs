using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorios_medicos.Presentacion
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();

        }

        private void menu_PacienteClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_MedicoClick(object sender, EventArgs e)
        {

        }

        private void menu_Principal_Click(object sender, EventArgs e)
        {

        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistroMedico form_RegistroMedico = new Form_RegistroMedico();
            form_RegistroMedico.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistroPaciente form_RegistroPaciente = new Form_RegistroPaciente();
            form_RegistroPaciente.Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ActualizarPaciente form_ActualizarPaciente = new Form_ActualizarPaciente();
            form_ActualizarPaciente.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ActualizarMedico form_ActualizarMedico = new Form_ActualizarMedico();
            form_ActualizarMedico.Show();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AgendarCita agendarCita = new Form_AgendarCita();
            agendarCita.Show();
        }
    }
}
