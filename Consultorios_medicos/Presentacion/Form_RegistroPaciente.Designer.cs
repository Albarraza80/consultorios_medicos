namespace Consultorios_medicos.Presentacion
{
    partial class Form_RegistroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegistroPaciente));
            label_TituloPaciente = new Label();
            pictureBox1 = new PictureBox();
            label_Cedula = new Label();
            textBox_Cedula = new TextBox();
            textBox_Nombre = new TextBox();
            label1 = new Label();
            textBox_Apellido = new TextBox();
            label2 = new Label();
            textBox_Correo = new TextBox();
            label3 = new Label();
            textBox_Telefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button_RegistrarPaciente = new Button();
            dateTime_Nacimiento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_TituloPaciente
            // 
            label_TituloPaciente.AutoSize = true;
            label_TituloPaciente.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_TituloPaciente.ForeColor = Color.Green;
            label_TituloPaciente.Location = new Point(152, 31);
            label_TituloPaciente.Name = "label_TituloPaciente";
            label_TituloPaciente.Size = new Size(185, 23);
            label_TituloPaciente.TabIndex = 0;
            label_TituloPaciente.Text = "Registro Pacientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label_Cedula
            // 
            label_Cedula.AutoSize = true;
            label_Cedula.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Cedula.Location = new Point(43, 100);
            label_Cedula.Name = "label_Cedula";
            label_Cedula.Size = new Size(61, 21);
            label_Cedula.TabIndex = 2;
            label_Cedula.Text = "Cédula";
            // 
            // textBox_Cedula
            // 
            textBox_Cedula.Location = new Point(152, 101);
            textBox_Cedula.Name = "textBox_Cedula";
            textBox_Cedula.Size = new Size(227, 23);
            textBox_Cedula.TabIndex = 3;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(152, 140);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(227, 23);
            textBox_Nombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 139);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // textBox_Apellido
            // 
            textBox_Apellido.Location = new Point(152, 178);
            textBox_Apellido.Name = "textBox_Apellido";
            textBox_Apellido.Size = new Size(227, 23);
            textBox_Apellido.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 177);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // textBox_Correo
            // 
            textBox_Correo.Location = new Point(152, 222);
            textBox_Correo.Name = "textBox_Correo";
            textBox_Correo.Size = new Size(227, 23);
            textBox_Correo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 221);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 8;
            label3.Text = "Correo";
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Location = new Point(152, 263);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(227, 23);
            textBox_Telefono.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 262);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 10;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 306);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 12;
            label5.Text = "F. Nacimiento";
            // 
            // button_RegistrarPaciente
            // 
            button_RegistrarPaciente.Location = new Point(361, 376);
            button_RegistrarPaciente.Name = "button_RegistrarPaciente";
            button_RegistrarPaciente.Size = new Size(96, 28);
            button_RegistrarPaciente.TabIndex = 14;
            button_RegistrarPaciente.Text = "Registrar";
            button_RegistrarPaciente.UseVisualStyleBackColor = true;
            button_RegistrarPaciente.Click += button_RegistrarPaciente_Click;
            // 
            // dateTime_Nacimiento
            // 
            dateTime_Nacimiento.Location = new Point(152, 304);
            dateTime_Nacimiento.Name = "dateTime_Nacimiento";
            dateTime_Nacimiento.Size = new Size(227, 23);
            dateTime_Nacimiento.TabIndex = 15;
            // 
            // Form_RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 428);
            Controls.Add(dateTime_Nacimiento);
            Controls.Add(button_RegistrarPaciente);
            Controls.Add(label5);
            Controls.Add(textBox_Telefono);
            Controls.Add(label4);
            Controls.Add(textBox_Correo);
            Controls.Add(label3);
            Controls.Add(textBox_Apellido);
            Controls.Add(label2);
            Controls.Add(textBox_Nombre);
            Controls.Add(label1);
            Controls.Add(textBox_Cedula);
            Controls.Add(label_Cedula);
            Controls.Add(pictureBox1);
            Controls.Add(label_TituloPaciente);
            Name = "Form_RegistroPaciente";
            Text = "Form_RegistroPaciente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TituloPaciente;
        private PictureBox pictureBox1;
        private Label label_Cedula;
        private TextBox textBox_Cedula;
        private TextBox textBox_Nombre;
        private Label label1;
        private TextBox textBox_Apellido;
        private Label label2;
        private TextBox textBox_Correo;
        private Label label3;
        private TextBox textBox_Telefono;
        private Label label4;
        private Label label5;
        private Button button_RegistrarPaciente;
        private DateTimePicker dateTime_Nacimiento;
    }
}