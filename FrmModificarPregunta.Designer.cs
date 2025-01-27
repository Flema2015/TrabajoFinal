namespace TrabajoFinal_
{
    partial class FrmModificarPregunta
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
            btnAceptar = new Button();
            btnVolver = new Button();
            lblPreguntaID = new Label();
            cmbNumeroRespuesta = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            lblSubUnidadModificar = new Label();
            btnModificarRespuesta = new Button();
            txtPregunta = new TextBox();
            txtSubUnidad = new TextBox();
            txtUnidad = new TextBox();
            txtAsignatura = new TextBox();
            txtRespuestaCorrecta = new TextBox();
            txtRespuesta = new TextBox();
            label2 = new Label();
            btnBuscarIDpregunta = new Button();
            cmbCarrera = new ComboBox();
            label7 = new Label();
            cmbAsignatura = new ComboBox();
            lblAsignatura = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lstPreguntas = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(533, 463);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(685, 463);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblPreguntaID
            // 
            lblPreguntaID.AutoSize = true;
            lblPreguntaID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaID.ForeColor = SystemColors.ControlText;
            lblPreguntaID.Location = new Point(504, 12);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(93, 20);
            lblPreguntaID.TabIndex = 2;
            lblPreguntaID.Text = "ID Pregunta";
            // 
            // cmbNumeroRespuesta
            // 
            cmbNumeroRespuesta.FormattingEnabled = true;
            cmbNumeroRespuesta.Location = new Point(599, 224);
            cmbNumeroRespuesta.Name = "cmbNumeroRespuesta";
            cmbNumeroRespuesta.Size = new Size(55, 23);
            cmbNumeroRespuesta.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(517, 186);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 4;
            label3.Text = "Lista de Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(508, 223);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Respuesta ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(517, 269);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 6;
            label5.Text = "Respuesta correcta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(517, 311);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 7;
            label6.Text = "Asignatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(517, 352);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "Unidad";
            // 
            // lblSubUnidadModificar
            // 
            lblSubUnidadModificar.AutoSize = true;
            lblSubUnidadModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubUnidadModificar.Location = new Point(517, 392);
            lblSubUnidadModificar.Name = "lblSubUnidadModificar";
            lblSubUnidadModificar.Size = new Size(91, 20);
            lblSubUnidadModificar.TabIndex = 9;
            lblSubUnidadModificar.Text = "Sub-Unidad";
            // 
            // btnModificarRespuesta
            // 
            btnModificarRespuesta.Location = new Point(816, 224);
            btnModificarRespuesta.Name = "btnModificarRespuesta";
            btnModificarRespuesta.Size = new Size(75, 23);
            btnModificarRespuesta.TabIndex = 10;
            btnModificarRespuesta.Text = "Modificar";
            btnModificarRespuesta.UseVisualStyleBackColor = true;
            btnModificarRespuesta.Click += btnModificarRespuesta_Click;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(651, 143);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(100, 23);
            txtPregunta.TabIndex = 12;
            // 
            // txtSubUnidad
            // 
            txtSubUnidad.Location = new Point(660, 389);
            txtSubUnidad.Name = "txtSubUnidad";
            txtSubUnidad.Size = new Size(100, 23);
            txtSubUnidad.TabIndex = 18;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(660, 349);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 19;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(660, 308);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(100, 23);
            txtAsignatura.TabIndex = 20;
            // 
            // txtRespuestaCorrecta
            // 
            txtRespuestaCorrecta.Location = new Point(660, 266);
            txtRespuestaCorrecta.Name = "txtRespuestaCorrecta";
            txtRespuestaCorrecta.Size = new Size(100, 23);
            txtRespuestaCorrecta.TabIndex = 21;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(698, 224);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(100, 23);
            txtRespuesta.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(508, 146);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Pregunta";
            // 
            // btnBuscarIDpregunta
            // 
            btnBuscarIDpregunta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarIDpregunta.Location = new Point(504, 41);
            btnBuscarIDpregunta.Name = "btnBuscarIDpregunta";
            btnBuscarIDpregunta.Size = new Size(150, 50);
            btnBuscarIDpregunta.TabIndex = 25;
            btnBuscarIDpregunta.Text = "Buscar preguntas";
            btnBuscarIDpregunta.UseVisualStyleBackColor = true;
            btnBuscarIDpregunta.Click += btnBuscarIDpregunta_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(123, 12);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(360, 33);
            cmbCarrera.TabIndex = 29;
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 28;
            label7.Text = "Carrera";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(123, 51);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(360, 33);
            cmbAsignatura.TabIndex = 27;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(8, 51);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 26;
            lblAsignatura.Text = "Asignatura";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(669, 187);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 31;
            // 
            // lstPreguntas
            // 
            lstPreguntas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPreguntas.FormattingEnabled = true;
            lstPreguntas.ItemHeight = 17;
            lstPreguntas.Location = new Point(12, 90);
            lstPreguntas.Name = "lstPreguntas";
            lstPreguntas.Size = new Size(471, 429);
            lstPreguntas.TabIndex = 32;
            lstPreguntas.SelectedIndexChanged += lstPreguntas_SelectedIndexChanged;
            // 
            // FrmModificarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 533);
            Controls.Add(lstPreguntas);
            Controls.Add(maskedTextBox1);
            Controls.Add(cmbCarrera);
            Controls.Add(label7);
            Controls.Add(cmbAsignatura);
            Controls.Add(lblAsignatura);
            Controls.Add(btnBuscarIDpregunta);
            Controls.Add(cmbNumeroRespuesta);
            Controls.Add(txtRespuesta);
            Controls.Add(txtRespuestaCorrecta);
            Controls.Add(txtAsignatura);
            Controls.Add(txtUnidad);
            Controls.Add(txtSubUnidad);
            Controls.Add(txtPregunta);
            Controls.Add(btnModificarRespuesta);
            Controls.Add(lblSubUnidadModificar);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPreguntaID);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificarPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarPregunta";
            Load += FrmModificarPregunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnAceptar;
        private Button btnVolver;
        private Label lblPreguntaID;
        private ComboBox cmbNumeroRespuesta;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label lblSubUnidadModificar;
        private Button btnModificarRespuesta;
        private TextBox txtPregunta;
        private TextBox txtSubUnidad;
        private TextBox txtUnidad;
        private TextBox txtAsignatura;
        private TextBox txtRespuestaCorrecta;
        private TextBox txtRespuesta;
        private Label label2;
        private Button btnBuscarIDpregunta;
        private ComboBox cmbCarrera;
        private Label label7;
        private ComboBox cmbAsignatura;
        private Label lblAsignatura;
        private MaskedTextBox maskedTextBox1;
        private ListBox lstPreguntas;
    }
}