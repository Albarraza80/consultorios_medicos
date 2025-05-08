namespace Consultorios_medicos.Presentacion
{
    partial class Form_AgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgendarCita));
            label1 = new Label();
            textBox_Cedula = new TextBox();
            textBox_Motivo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker_Fecha = new DateTimePicker();
            label5 = new Label();
            button1 = new Button();
            button_Agendar = new Button();
            comboBox_Hora = new ComboBox();
            pictureBox1 = new PictureBox();
            label_TituloPaciente = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            textBox_Nombre = new TextBox();
            label7 = new Label();
            comboBox_Estado = new ComboBox();
            comboBox_Medico = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F);
            label1.Location = new Point(99, 110);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Cedula";
            // 
            // textBox_Cedula
            // 
            textBox_Cedula.Location = new Point(180, 108);
            textBox_Cedula.Name = "textBox_Cedula";
            textBox_Cedula.Size = new Size(192, 23);
            textBox_Cedula.TabIndex = 1;
            // 
            // textBox_Motivo
            // 
            textBox_Motivo.Location = new Point(179, 185);
            textBox_Motivo.Name = "textBox_Motivo";
            textBox_Motivo.Size = new Size(192, 23);
            textBox_Motivo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F);
            label2.Location = new Point(98, 187);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Motivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F);
            label3.Location = new Point(98, 232);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F);
            label4.Location = new Point(99, 271);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 6;
            label4.Text = "Fecha";
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Location = new Point(181, 272);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new Size(191, 23);
            dateTimePicker_Fecha.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F);
            label5.Location = new Point(99, 364);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 8;
            label5.Text = "Medico";
            // 
            // button1
            // 
            button1.Location = new Point(390, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_Agendar
            // 
            button_Agendar.Location = new Point(390, 393);
            button_Agendar.Name = "button_Agendar";
            button_Agendar.Size = new Size(75, 23);
            button_Agendar.TabIndex = 11;
            button_Agendar.Text = "Agendar";
            button_Agendar.UseVisualStyleBackColor = true;
            button_Agendar.Click += button2_Click;
            // 
            // comboBox_Hora
            // 
            comboBox_Hora.FormattingEnabled = true;
            comboBox_Hora.Items.AddRange(new object[] { "08:00 a.m.", "09:00 a.m.", "10:00 a.m.", "2:00 p.m.", "3:00 p.m.", "4:00 p.m" });
            comboBox_Hora.Location = new Point(181, 320);
            comboBox_Hora.Name = "comboBox_Hora";
            comboBox_Hora.Size = new Size(191, 23);
            comboBox_Hora.TabIndex = 12;
            comboBox_Hora.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 100);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label_TituloPaciente
            // 
            label_TituloPaciente.AutoSize = true;
            label_TituloPaciente.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_TituloPaciente.ForeColor = Color.Green;
            label_TituloPaciente.Location = new Point(181, 40);
            label_TituloPaciente.Name = "label_TituloPaciente";
            label_TituloPaciente.Size = new Size(133, 23);
            label_TituloPaciente.TabIndex = 17;
            label_TituloPaciente.Text = "Agendar Cita";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(423, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 92);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F);
            label6.Location = new Point(99, 321);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 19;
            label6.Text = "Hora";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(180, 146);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(192, 23);
            textBox_Nombre.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F);
            label7.Location = new Point(99, 148);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 20;
            label7.Text = "Nombre";
            // 
            // comboBox_Estado
            // 
            comboBox_Estado.FormattingEnabled = true;
            comboBox_Estado.Items.AddRange(new object[] { "Pendiente", "Atendida", "Cancelada" });
            comboBox_Estado.Location = new Point(181, 230);
            comboBox_Estado.Name = "comboBox_Estado";
            comboBox_Estado.Size = new Size(191, 23);
            comboBox_Estado.TabIndex = 22;
            comboBox_Estado.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox_Medico
            // 
            comboBox_Medico.FormattingEnabled = true;
            comboBox_Medico.Items.AddRange(new object[] { "Pendiente", "Atendida", "Cancelada" });
            comboBox_Medico.Location = new Point(181, 362);
            comboBox_Medico.Name = "comboBox_Medico";
            comboBox_Medico.Size = new Size(191, 23);
            comboBox_Medico.TabIndex = 23;
            // 
            // Form_AgendarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 428);
            Controls.Add(comboBox_Medico);
            Controls.Add(comboBox_Estado);
            Controls.Add(textBox_Nombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label_TituloPaciente);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox_Hora);
            Controls.Add(button_Agendar);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker_Fecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_Motivo);
            Controls.Add(label2);
            Controls.Add(textBox_Cedula);
            Controls.Add(label1);
            Name = "Form_AgendarCita";
            Text = "Form_AgendarCita";
            Load += Form_AgendarCita_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Cedula;
        private TextBox textBox_Motivo;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker_Fecha;
        private Label label5;
        private Button button1;
        private Button button_Agendar;
        private ComboBox comboBox_Hora;
        private PictureBox pictureBox1;
        private Label label_TituloPaciente;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox textBox_Nombre;
        private Label label7;
        private ComboBox comboBox_Estado;
        private ComboBox comboBox_Medico;
    }
}