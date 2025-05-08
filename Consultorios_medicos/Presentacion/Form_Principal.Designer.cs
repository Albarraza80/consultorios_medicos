namespace Consultorios_medicos.Presentacion
{
    partial class Form_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            menuStrip1 = new MenuStrip();
            menu_Principal = new ToolStripMenuItem();
            menu_Paciente = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem1 = new ToolStripMenuItem();
            menu_Medico = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            agendarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            picture_Principal = new PictureBox();
            label_TituloPrincipal = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Principal).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_Principal, citasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(499, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_Principal
            // 
            menu_Principal.DropDownItems.AddRange(new ToolStripItem[] { menu_Paciente, menu_Medico });
            menu_Principal.Name = "menu_Principal";
            menu_Principal.Size = new Size(62, 20);
            menu_Principal.Text = "Registro";
            menu_Principal.Click += menu_Principal_Click;
            // 
            // menu_Paciente
            // 
            menu_Paciente.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, actualizarToolStripMenuItem1 });
            menu_Paciente.Name = "menu_Paciente";
            menu_Paciente.Size = new Size(119, 22);
            menu_Paciente.Text = "Paciente";
            menu_Paciente.Click += menu_PacienteClick;
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(126, 22);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem1
            // 
            actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            actualizarToolStripMenuItem1.Size = new Size(126, 22);
            actualizarToolStripMenuItem1.Text = "Actualizar";
            actualizarToolStripMenuItem1.Click += actualizarToolStripMenuItem1_Click;
            // 
            // menu_Medico
            // 
            menu_Medico.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, actualizarToolStripMenuItem });
            menu_Medico.Name = "menu_Medico";
            menu_Medico.Size = new Size(119, 22);
            menu_Medico.Text = "Médico";
            menu_Medico.Click += menu_MedicoClick;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(126, 22);
            nuevoToolStripMenuItem.Text = "Registrar";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendarToolStripMenuItem, visualizarToolStripMenuItem });
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(45, 20);
            citasToolStripMenuItem.Text = "Citas";
            // 
            // agendarToolStripMenuItem
            // 
            agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            agendarToolStripMenuItem.Size = new Size(180, 22);
            agendarToolStripMenuItem.Text = "Agendar";
            agendarToolStripMenuItem.Click += agendarToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(180, 22);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // picture_Principal
            // 
            picture_Principal.Image = (Image)resources.GetObject("picture_Principal.Image");
            picture_Principal.Location = new Point(12, 93);
            picture_Principal.Name = "picture_Principal";
            picture_Principal.Size = new Size(475, 323);
            picture_Principal.TabIndex = 1;
            picture_Principal.TabStop = false;
            // 
            // label_TituloPrincipal
            // 
            label_TituloPrincipal.AutoSize = true;
            label_TituloPrincipal.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_TituloPrincipal.ForeColor = SystemColors.Highlight;
            label_TituloPrincipal.Location = new Point(146, 24);
            label_TituloPrincipal.Name = "label_TituloPrincipal";
            label_TituloPrincipal.Size = new Size(214, 50);
            label_TituloPrincipal.TabIndex = 2;
            label_TituloPrincipal.Text = "Sistema de Registro\n       CunMedica";
            label_TituloPrincipal.Click += label1_Click;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 428);
            Controls.Add(label_TituloPrincipal);
            Controls.Add(picture_Principal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Principal";
            Text = "Consultas Médicas";
            Load += Form_Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Principal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_Principal;
        private ToolStripMenuItem menu_Paciente;
        private ToolStripMenuItem menu_Medico;
        private PictureBox picture_Principal;
        private Label label_TituloPrincipal;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem1;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem agendarToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
    }
}