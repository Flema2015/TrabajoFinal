namespace TrabajoFinal_
{
    partial class FrmAltaPregunta
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
            lblPreguntaID = new Label();
            lblPregunta = new Label();
            lblListaRespuestas = new Label();
            lblRespuestaCorrecta = new Label();
            lblAsignatura = new Label();
            lblUnidad = new Label();
            lblSubUnidad = new Label();
            txtPregunta = new TextBox();
            txtRespuesta = new TextBox();
            txtRespuestaCorrecta = new TextBox();
            txtAsignatura = new TextBox();
            txtUnidad = new TextBox();
            txtSubUnidad = new TextBox();
            cmbRespuestas = new ComboBox();
            btnCargarRespuesta = new Button();
            lblRespuestas = new Label();
            btnAceptar = new Button();
            btnVolver = new Button();
            lblIDPregunta = new Label();
            SuspendLayout();
            // 
            // lblPreguntaID
            // 
            lblPreguntaID.AutoSize = true;
            lblPreguntaID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaID.Location = new Point(104, 33);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(89, 20);
            lblPreguntaID.TabIndex = 2;
            lblPreguntaID.Text = "PreguntaID";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(104, 74);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(73, 20);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "Pregunta";
            // 
            // lblListaRespuestas
            // 
            lblListaRespuestas.AutoSize = true;
            lblListaRespuestas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaRespuestas.Location = new Point(104, 114);
            lblListaRespuestas.Name = "lblListaRespuestas";
            lblListaRespuestas.Size = new Size(148, 20);
            lblListaRespuestas.TabIndex = 4;
            lblListaRespuestas.Text = "Lista De Respuestas";
            // 
            // lblRespuestaCorrecta
            // 
            lblRespuestaCorrecta.AutoSize = true;
            lblRespuestaCorrecta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuestaCorrecta.Location = new Point(104, 188);
            lblRespuestaCorrecta.Name = "lblRespuestaCorrecta";
            lblRespuestaCorrecta.Size = new Size(144, 20);
            lblRespuestaCorrecta.TabIndex = 5;
            lblRespuestaCorrecta.Text = "Respuesta Correcta";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(104, 229);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(86, 20);
            lblAsignatura.TabIndex = 6;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidad.Location = new Point(104, 267);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(59, 20);
            lblUnidad.TabIndex = 7;
            lblUnidad.Text = "Unidad";
            // 
            // lblSubUnidad
            // 
            lblSubUnidad.AutoSize = true;
            lblSubUnidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubUnidad.Location = new Point(102, 304);
            lblSubUnidad.Name = "lblSubUnidad";
            lblSubUnidad.Size = new Size(91, 20);
            lblSubUnidad.TabIndex = 8;
            lblSubUnidad.Text = "Sub-Unidad";
            // 
            // txtPregunta
            // 
            txtPregunta.BorderStyle = BorderStyle.FixedSingle;
            txtPregunta.Location = new Point(212, 75);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(287, 23);
            txtPregunta.TabIndex = 9;
            txtPregunta.MouseClick += txtPregunta_MouseClick;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(226, 150);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(100, 23);
            txtRespuesta.TabIndex = 10;
            // 
            // txtRespuestaCorrecta
            // 
            txtRespuestaCorrecta.Location = new Point(254, 189);
            txtRespuestaCorrecta.Name = "txtRespuestaCorrecta";
            txtRespuestaCorrecta.Size = new Size(100, 23);
            txtRespuestaCorrecta.TabIndex = 11;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(214, 229);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(100, 23);
            txtAsignatura.TabIndex = 12;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(212, 267);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 13;
            // 
            // txtSubUnidad
            // 
            txtSubUnidad.Location = new Point(212, 305);
            txtSubUnidad.Name = "txtSubUnidad";
            txtSubUnidad.Size = new Size(100, 23);
            txtSubUnidad.TabIndex = 14;
            // 
            // cmbRespuestas
            // 
            cmbRespuestas.FormattingEnabled = true;
            cmbRespuestas.Location = new Point(470, 147);
            cmbRespuestas.Name = "cmbRespuestas";
            cmbRespuestas.Size = new Size(121, 23);
            cmbRespuestas.TabIndex = 15;
            // 
            // btnCargarRespuesta
            // 
            btnCargarRespuesta.Location = new Point(352, 141);
            btnCargarRespuesta.Name = "btnCargarRespuesta";
            btnCargarRespuesta.Size = new Size(97, 41);
            btnCargarRespuesta.TabIndex = 16;
            btnCargarRespuesta.Text = "Cargar Respuesta";
            btnCargarRespuesta.UseVisualStyleBackColor = true;
            // 
            // lblRespuestas
            // 
            lblRespuestas.AutoSize = true;
            lblRespuestas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuestas.Location = new Point(104, 150);
            lblRespuestas.Name = "lblRespuestas";
            lblRespuestas.Size = new Size(107, 20);
            lblRespuestas.TabIndex = 17;
            lblRespuestas.Text = "Respuesta #1:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(242, 357);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 29);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(366, 358);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 29);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += this.btnVolver_Click;
            // 
            // lblIDPregunta
            // 
            lblIDPregunta.AutoSize = true;
            lblIDPregunta.Location = new Point(212, 37);
            lblIDPregunta.Name = "lblIDPregunta";
            lblIDPregunta.Size = new Size(13, 15);
            lblIDPregunta.TabIndex = 20;
            lblIDPregunta.Text = "1";
            // 
            // FrmAltaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(lblIDPregunta);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(lblRespuestas);
            Controls.Add(btnCargarRespuesta);
            Controls.Add(cmbRespuestas);
            Controls.Add(txtSubUnidad);
            Controls.Add(txtUnidad);
            Controls.Add(txtAsignatura);
            Controls.Add(txtRespuestaCorrecta);
            Controls.Add(txtRespuesta);
            Controls.Add(txtPregunta);
            Controls.Add(lblSubUnidad);
            Controls.Add(lblUnidad);
            Controls.Add(lblAsignatura);
            Controls.Add(lblRespuestaCorrecta);
            Controls.Add(lblListaRespuestas);
            Controls.Add(lblPregunta);
            Controls.Add(lblPreguntaID);
            Name = "FrmAltaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPreguntaID;
        private Label lblPreguntaID;
        private Label lblPregunta;
        private Label lblListaRespuestas;
        private Label lblRespuestaCorrecta;
        private Label lblAsignatura;
        private Label lblUnidad;
        private Label lblSubUnidad;
        private TextBox txtPregunta;
        private TextBox txtRespuesta;
        private TextBox txtRespuestaCorrecta;
        private TextBox txtAsignatura;
        private TextBox txtUnidad;
        private TextBox txtSubUnidad;
        private ComboBox cmbRespuestas;
        private Button btnCargarRespuesta;
        private Label lblRespuestas;
        private Button btnAceptar;
        private Button btnVolver;
        private Label lblIDPregunta;
    }
}