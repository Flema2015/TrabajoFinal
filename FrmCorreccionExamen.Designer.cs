﻿namespace TrabajoFinal_
{
    partial class FrmCorreccionEx
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
            btnBuscarRespuestas = new Button();
            btnVolver = new Button();
            lblIDExamen = new Label();
            lblNombreAlumno = new Label();
            txtIDExamen = new TextBox();
            txtNombreAlumno = new TextBox();
            btnVerDevolucion = new Button();
            SuspendLayout();
            // 
            // btnBuscarRespuestas
            // 
            btnBuscarRespuestas.Location = new Point(171, 244);
            btnBuscarRespuestas.Name = "btnBuscarRespuestas";
            btnBuscarRespuestas.Size = new Size(114, 23);
            btnBuscarRespuestas.TabIndex = 0;
            btnBuscarRespuestas.Text = "Buscar respuestas";
            btnBuscarRespuestas.UseVisualStyleBackColor = true;
            btnBuscarRespuestas.Click += btnBuscarRespuestas_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(463, 244);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(97, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIDExamen
            // 
            lblIDExamen.AutoSize = true;
            lblIDExamen.Location = new Point(251, 103);
            lblIDExamen.Name = "lblIDExamen";
            lblIDExamen.Size = new Size(63, 15);
            lblIDExamen.TabIndex = 2;
            lblIDExamen.Text = "ID Examen";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(147, 166);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(167, 15);
            lblNombreAlumno.TabIndex = 3;
            lblNombreAlumno.Text = "Nombre y Apellido de alumno";
            // 
            // txtIDExamen
            // 
            txtIDExamen.Location = new Point(335, 100);
            txtIDExamen.Name = "txtIDExamen";
            txtIDExamen.Size = new Size(100, 23);
            txtIDExamen.TabIndex = 4;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(335, 163);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(100, 23);
            txtNombreAlumno.TabIndex = 5;
            // 
            // btnVerDevolucion
            // 
            btnVerDevolucion.Location = new Point(324, 244);
            btnVerDevolucion.Name = "btnVerDevolucion";
            btnVerDevolucion.Size = new Size(100, 23);
            btnVerDevolucion.TabIndex = 6;
            btnVerDevolucion.Text = "Ver devolucion";
            btnVerDevolucion.UseVisualStyleBackColor = true;
            btnVerDevolucion.Click += btnVerDevolucion_Click;
            // 
            // FrmCorreccionEx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVerDevolucion);
            Controls.Add(txtNombreAlumno);
            Controls.Add(txtIDExamen);
            Controls.Add(lblNombreAlumno);
            Controls.Add(lblIDExamen);
            Controls.Add(btnVolver);
            Controls.Add(btnBuscarRespuestas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCorreccionEx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corección de Exámenes";
            FormClosed += FrmCorreccionEx_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarRespuestas;
        private Button btnVolver;
        private Label lblIDExamen;
        private Label lblNombreAlumno;
        private TextBox txtIDExamen;
        private TextBox txtNombreAlumno;
        private Button btnVerDevolucion;
    }
}