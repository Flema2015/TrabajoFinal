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
            txtIDPregunta = new TextBox();
            txtPregunta = new TextBox();
            txtSubUnidad = new TextBox();
            txtUnidad = new TextBox();
            txtAsignatura = new TextBox();
            txtRespuestaCorrecta = new TextBox();
            txtRespuesta = new TextBox();
            label2 = new Label();
            btnBuscarIDpregunta = new Button();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(195, 397);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(347, 397);
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
            lblPreguntaID.Location = new Point(152, 59);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(93, 20);
            lblPreguntaID.TabIndex = 2;
            lblPreguntaID.Text = "ID Pregunta";
            // 
            // cmbNumeroRespuesta
            // 
            cmbNumeroRespuesta.FormattingEnabled = true;
            cmbNumeroRespuesta.Location = new Point(234, 176);
            cmbNumeroRespuesta.Name = "cmbNumeroRespuesta";
            cmbNumeroRespuesta.Size = new Size(55, 23);
            cmbNumeroRespuesta.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 138);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 4;
            label3.Text = "Lista de Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 175);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Respuesta ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(152, 221);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 6;
            label5.Text = "Respuesta correcta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(152, 263);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 7;
            label6.Text = "Asignatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 304);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "Unidad";
            // 
            // lblSubUnidadModificar
            // 
            lblSubUnidadModificar.AutoSize = true;
            lblSubUnidadModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubUnidadModificar.Location = new Point(152, 344);
            lblSubUnidadModificar.Name = "lblSubUnidadModificar";
            lblSubUnidadModificar.Size = new Size(91, 20);
            lblSubUnidadModificar.TabIndex = 9;
            lblSubUnidadModificar.Text = "Sub-Unidad";
            // 
            // btnModificarRespuesta
            // 
            btnModificarRespuesta.Location = new Point(451, 176);
            btnModificarRespuesta.Name = "btnModificarRespuesta";
            btnModificarRespuesta.Size = new Size(75, 23);
            btnModificarRespuesta.TabIndex = 10;
            btnModificarRespuesta.Text = "Modificar";
            btnModificarRespuesta.UseVisualStyleBackColor = true;
            btnModificarRespuesta.Click += btnModificarRespuesta_Click;
            // 
            // txtIDPregunta
            // 
            txtIDPregunta.Location = new Point(295, 56);
            txtIDPregunta.Name = "txtIDPregunta";
            txtIDPregunta.Size = new Size(100, 23);
            txtIDPregunta.TabIndex = 11;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(295, 94);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(100, 23);
            txtPregunta.TabIndex = 12;
            // 
            // txtSubUnidad
            // 
            txtSubUnidad.Location = new Point(295, 341);
            txtSubUnidad.Name = "txtSubUnidad";
            txtSubUnidad.Size = new Size(100, 23);
            txtSubUnidad.TabIndex = 18;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(295, 301);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 19;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(295, 260);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(100, 23);
            txtAsignatura.TabIndex = 20;
            // 
            // txtRespuestaCorrecta
            // 
            txtRespuestaCorrecta.Location = new Point(295, 218);
            txtRespuestaCorrecta.Name = "txtRespuestaCorrecta";
            txtRespuestaCorrecta.Size = new Size(100, 23);
            txtRespuestaCorrecta.TabIndex = 21;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(333, 176);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(100, 23);
            txtRespuesta.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 97);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Pregunta";
            // 
            // btnBuscarIDpregunta
            // 
            btnBuscarIDpregunta.Location = new Point(429, 61);
            btnBuscarIDpregunta.Name = "btnBuscarIDpregunta";
            btnBuscarIDpregunta.Size = new Size(75, 23);
            btnBuscarIDpregunta.TabIndex = 25;
            btnBuscarIDpregunta.Text = "Buscar ID";
            btnBuscarIDpregunta.UseVisualStyleBackColor = true;
            btnBuscarIDpregunta.Click += btnBuscarIDpregunta_Click;
            // 
            // FrmModificarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 441);
            Controls.Add(btnBuscarIDpregunta);
            Controls.Add(cmbNumeroRespuesta);
            Controls.Add(txtRespuesta);
            Controls.Add(txtRespuestaCorrecta);
            Controls.Add(txtAsignatura);
            Controls.Add(txtUnidad);
            Controls.Add(txtSubUnidad);
            Controls.Add(txtPregunta);
            Controls.Add(txtIDPregunta);
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
        private TextBox txtIDPregunta;
        private TextBox txtPregunta;
        private TextBox txtSubUnidad;
        private TextBox txtUnidad;
        private TextBox txtAsignatura;
        private TextBox txtRespuestaCorrecta;
        private TextBox txtRespuesta;
        private Label label2;
        private Button btnBuscarIDpregunta;
    }
}