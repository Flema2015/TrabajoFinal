
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
            components = new System.ComponentModel.Container();
            lblPreguntaID = new Label();
            lblPregunta = new Label();
            lblListaRespuestas = new Label();
            lblRespuestaCorrecta = new Label();
            lblAsignatura = new Label();
            lblUnidad = new Label();
            lblSubUnidad = new Label();
            txtPregunta = new TextBox();
            txtRespuesta = new TextBox();
            txtAsignatura = new TextBox();
            txtUnidad = new TextBox();
            txtSubUnidad = new TextBox();
            cmbRespuestas = new ComboBox();
            btnCargarRespuesta = new Button();
            lblRespuestas = new Label();
            btnAceptar = new Button();
            btnVolver = new Button();
            alertaVacio = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)alertaVacio).BeginInit();
            SuspendLayout();
            // 
            // lblPreguntaID
            // 
            lblPreguntaID.AutoSize = true;
            lblPreguntaID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaID.Location = new Point(85, 9);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(120, 25);
            lblPreguntaID.TabIndex = 0;
            lblPreguntaID.Text = "Pregunta ID";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(110, 54);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(95, 25);
            lblPregunta.TabIndex = 1;
            lblPregunta.Text = "Pregunta";
            // 
            // lblListaRespuestas
            // 
            lblListaRespuestas.AutoSize = true;
            lblListaRespuestas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaRespuestas.Location = new Point(28, 98);
            lblListaRespuestas.Name = "lblListaRespuestas";
            lblListaRespuestas.Size = new Size(177, 25);
            lblListaRespuestas.TabIndex = 3;
            lblListaRespuestas.Text = "Lista de respuestas";
            // 
            // lblRespuestaCorrecta
            // 
            lblRespuestaCorrecta.AutoSize = true;
            lblRespuestaCorrecta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuestaCorrecta.Location = new Point(23, 178);
            lblRespuestaCorrecta.Name = "lblRespuestaCorrecta";
            lblRespuestaCorrecta.Size = new Size(182, 25);
            lblRespuestaCorrecta.TabIndex = 7;
            lblRespuestaCorrecta.Text = "Respuesta Correcta";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(96, 224);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 9;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidad.Location = new Point(126, 267);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(77, 25);
            lblUnidad.TabIndex = 11;
            lblUnidad.Text = "Unidad";
            // 
            // lblSubUnidad
            // 
            lblSubUnidad.AutoSize = true;
            lblSubUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubUnidad.Location = new Point(85, 310);
            lblSubUnidad.Name = "lblSubUnidad";
            lblSubUnidad.Size = new Size(120, 25);
            lblSubUnidad.TabIndex = 13;
            lblSubUnidad.Text = "Sub-Unidad";
            // 
            // txtPregunta
            // 
            txtPregunta.BorderStyle = BorderStyle.FixedSingle;
            txtPregunta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPregunta.Location = new Point(211, 52);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(360, 33);
            txtPregunta.TabIndex = 2;
            txtPregunta.MouseClick += txtPregunta_MouseClick;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRespuesta.Location = new Point(211, 131);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(360, 33);
            txtRespuesta.TabIndex = 5;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsignatura.Location = new Point(211, 221);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(360, 33);
            txtAsignatura.TabIndex = 10;
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidad.Location = new Point(211, 264);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(360, 33);
            txtUnidad.TabIndex = 12;
            // 
            // txtSubUnidad
            // 
            txtSubUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubUnidad.Location = new Point(211, 307);
            txtSubUnidad.Name = "txtSubUnidad";
            txtSubUnidad.Size = new Size(360, 33);
            txtSubUnidad.TabIndex = 14;
            // 
            // cmbRespuestas
            // 
            cmbRespuestas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRespuestas.FormattingEnabled = true;
            cmbRespuestas.Location = new Point(211, 175);
            cmbRespuestas.Name = "cmbRespuestas";
            cmbRespuestas.Size = new Size(360, 33);
            cmbRespuestas.TabIndex = 8;
            // 
            // btnCargarRespuesta
            // 
            btnCargarRespuesta.BackColor = Color.White;
            btnCargarRespuesta.FlatAppearance.BorderColor = Color.Black;
            btnCargarRespuesta.FlatAppearance.BorderSize = 0;
            btnCargarRespuesta.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnCargarRespuesta.FlatStyle = FlatStyle.Flat;
            btnCargarRespuesta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarRespuesta.Location = new Point(577, 123);
            btnCargarRespuesta.Name = "btnCargarRespuesta";
            btnCargarRespuesta.Size = new Size(150, 50);
            btnCargarRespuesta.TabIndex = 6;
            btnCargarRespuesta.Text = "Cargar Respuesta";
            btnCargarRespuesta.UseVisualStyleBackColor = false;
            btnCargarRespuesta.Click += btnCargarRespuesta_Click;
            // 
            // lblRespuestas
            // 
            lblRespuestas.AutoSize = true;
            lblRespuestas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuestas.Location = new Point(77, 134);
            lblRespuestas.Name = "lblRespuestas";
            lblRespuestas.Size = new Size(128, 25);
            lblRespuestas.TabIndex = 4;
            lblRespuestas.Text = "Respuesta #1";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(236, 349);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 50);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(392, 349);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 50);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // alertaVacio
            // 
            alertaVacio.ContainerControl = this;
            // 
            // FrmAltaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(lblRespuestas);
            Controls.Add(btnCargarRespuesta);
            Controls.Add(cmbRespuestas);
            Controls.Add(txtSubUnidad);
            Controls.Add(txtUnidad);
            Controls.Add(txtAsignatura);
            Controls.Add(txtRespuesta);
            Controls.Add(txtPregunta);
            Controls.Add(lblSubUnidad);
            Controls.Add(lblUnidad);
            Controls.Add(lblAsignatura);
            Controls.Add(lblRespuestaCorrecta);
            Controls.Add(lblListaRespuestas);
            Controls.Add(lblPregunta);
            Controls.Add(lblPreguntaID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAltaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAltaPregunta";
            ((System.ComponentModel.ISupportInitialize)alertaVacio).EndInit();
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
        private TextBox txtAsignatura;
        private TextBox txtUnidad;
        private TextBox txtSubUnidad;
        private ComboBox cmbRespuestas;
        private Button btnCargarRespuesta;
        private Label lblRespuestas;
        private Button btnAceptar;
        private Button btnVolver;
        private ErrorProvider alertaVacio;
    }
}