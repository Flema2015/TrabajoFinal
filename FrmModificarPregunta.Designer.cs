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
            btnSalir = new Button();
            lblPreguntaID = new Label();
            label2 = new Label();
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
            cmbNumeroRespuesta = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(280, 397);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(410, 397);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPreguntaID
            // 
            lblPreguntaID.AutoSize = true;
            lblPreguntaID.Location = new Point(152, 59);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(69, 15);
            lblPreguntaID.TabIndex = 2;
            lblPreguntaID.Text = "ID Pregunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 97);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Pregunta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 138);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Lista de Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 179);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 5;
            label4.Text = "Respuesta N°";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 221);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 6;
            label5.Text = "Respuesta correcta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 263);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 7;
            label6.Text = "Asignatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 304);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Unidad";
            // 
            // lblSubUnidadModificar
            // 
            lblSubUnidadModificar.AutoSize = true;
            lblSubUnidadModificar.Location = new Point(152, 344);
            lblSubUnidadModificar.Name = "lblSubUnidadModificar";
            lblSubUnidadModificar.Size = new Size(70, 15);
            lblSubUnidadModificar.TabIndex = 9;
            lblSubUnidadModificar.Text = "Sub-Unidad";
            // 
            // btnModificarRespuesta
            // 
            btnModificarRespuesta.Location = new Point(465, 175);
            btnModificarRespuesta.Name = "btnModificarRespuesta";
            btnModificarRespuesta.Size = new Size(75, 23);
            btnModificarRespuesta.TabIndex = 10;
            btnModificarRespuesta.Text = "Modificar";
            btnModificarRespuesta.UseVisualStyleBackColor = true;
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
            // cmbNumeroRespuesta
            // 
            cmbNumeroRespuesta.FormattingEnabled = true;
            cmbNumeroRespuesta.Location = new Point(234, 176);
            cmbNumeroRespuesta.Name = "cmbNumeroRespuesta";
            cmbNumeroRespuesta.Size = new Size(55, 23);
            cmbNumeroRespuesta.TabIndex = 24;
            // 
            // FrmModificarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Name = "FrmModificarPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnSalir;
        private Label lblPreguntaID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label lblSubUnidadModificar;
        private Button btnModificarRespuesta;
        private TextBox txtIDPregunta;
        private TextBox txtPregunta;
        private TextBox txtRespuesta;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox txtSubUnidad;
        private TextBox txtUnidad;
        private TextBox txtAsignatura;
        private TextBox txtRespuestaCorrecta;
        private ComboBox cmbNumeroRespuesta;
    }
}