using Consultorios_medicos.Entidades;

namespace Consultorios_medicos.Presentacion
{
    partial class Form_ActualizarMedico
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

        private P_medico ObtenerMedicoDesdeFormulario()
        {
            return new P_medico
            {
                nombre = textBox_Nombre.Text,
                cedula = int.Parse(textBox_Cedula.Text),
                especialidad = (int)comboBox_Especialidad.SelectedValue,
                consultorio = int.Parse(textBox_Consultorio.Text),
                telefono = textBox_Telefono.Text,
                correo = textBox_Correo.Text
            };
        }

        private void LimpiarFormulario()
        {
            comboBox_Especialidad.Text = "";
            textBox_Correo.Text = "";
            textBox_Telefono.Text = "";
            textBox_Nombre.Text = "";
            textBox_Cedula.Text = "";
            textBox_Consultorio.Text = "";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ActualizarMedico));
            button_Guardar = new Button();
            comboBox_Especialidad = new ComboBox();
            textBox_Consultorio = new TextBox();
            label5 = new Label();
            textBox_Telefono = new TextBox();
            label4 = new Label();
            textBox_Correo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox_Nombre = new TextBox();
            label1 = new Label();
            textBox_Cedula = new TextBox();
            label_Cedula = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_TituloPaciente = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Guardar
            // 
            button_Guardar.Location = new Point(394, 381);
            button_Guardar.Name = "button_Guardar";
            button_Guardar.Size = new Size(75, 23);
            button_Guardar.TabIndex = 31;
            button_Guardar.Text = "Guardar";
            button_Guardar.UseVisualStyleBackColor = true;
            button_Guardar.Click += button_Guardar_Click;
            // 
            // comboBox_Especialidad
            // 
            comboBox_Especialidad.FormattingEnabled = true;
            comboBox_Especialidad.Location = new Point(144, 293);
            comboBox_Especialidad.Name = "comboBox_Especialidad";
            comboBox_Especialidad.Size = new Size(224, 23);
            comboBox_Especialidad.TabIndex = 43;
            comboBox_Especialidad.SelectedIndexChanged += comboBox_Especialidad_SelectedIndexChanged;
            // 
            // textBox_Consultorio
            // 
            textBox_Consultorio.Location = new Point(144, 332);
            textBox_Consultorio.Name = "textBox_Consultorio";
            textBox_Consultorio.Size = new Size(227, 23);
            textBox_Consultorio.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 334);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 41;
            label5.Text = "Consultorio";
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Location = new Point(144, 246);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(227, 23);
            textBox_Telefono.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 245);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 39;
            label4.Text = "Teléfono";
            // 
            // textBox_Correo
            // 
            textBox_Correo.Location = new Point(144, 205);
            textBox_Correo.Name = "textBox_Correo";
            textBox_Correo.Size = new Size(227, 23);
            textBox_Correo.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 204);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 37;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 289);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 36;
            label2.Text = "Especialidad";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(144, 166);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(227, 23);
            textBox_Nombre.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 165);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 34;
            label1.Text = "Nombre";
            // 
            // textBox_Cedula
            // 
            textBox_Cedula.Location = new Point(144, 127);
            textBox_Cedula.Name = "textBox_Cedula";
            textBox_Cedula.Size = new Size(227, 23);
            textBox_Cedula.TabIndex = 33;
            // 
            // label_Cedula
            // 
            label_Cedula.AutoSize = true;
            label_Cedula.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Cedula.Location = new Point(35, 126);
            label_Cedula.Name = "label_Cedula";
            label_Cedula.Size = new Size(61, 21);
            label_Cedula.TabIndex = 32;
            label_Cedula.Text = "Cédula";
            // 
            // button1
            // 
            button1.Location = new Point(394, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 79);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(427, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 105);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // label_TituloPaciente
            // 
            label_TituloPaciente.AutoSize = true;
            label_TituloPaciente.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_TituloPaciente.ForeColor = Color.Green;
            label_TituloPaciente.Location = new Point(162, 54);
            label_TituloPaciente.Name = "label_TituloPaciente";
            label_TituloPaciente.Size = new Size(178, 23);
            label_TituloPaciente.TabIndex = 47;
            label_TituloPaciente.Text = "Actualizar Médico";
            // 
            // Form_ActualizarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 428);
            Controls.Add(label_TituloPaciente);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(comboBox_Especialidad);
            Controls.Add(textBox_Consultorio);
            Controls.Add(label5);
            Controls.Add(textBox_Telefono);
            Controls.Add(label4);
            Controls.Add(textBox_Correo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Nombre);
            Controls.Add(label1);
            Controls.Add(textBox_Cedula);
            Controls.Add(label_Cedula);
            Controls.Add(button_Guardar);
            Name = "Form_ActualizarMedico";
            Text = "Form_ActualizarMedico";
            Load += Form_ActualizarMedico_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Guardar;
        private ComboBox comboBox_Especialidad;
        private TextBox textBox_Consultorio;
        private Label label5;
        private TextBox textBox_Telefono;
        private Label label4;
        private TextBox textBox_Correo;
        private Label label3;
        private Label label2;
        private TextBox textBox_Nombre;
        private Label label1;
        private TextBox textBox_Cedula;
        private Label label_Cedula;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label_TituloPaciente;
    }
}