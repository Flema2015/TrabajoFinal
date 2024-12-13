namespace TrabajoFinal_
{
    partial class FrmCargaDatosExamen
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
            btnEmpezarExamen = new Button();
            btnVolver = new Button();
            lblCarrera = new Label();
            lblAsignatura = new Label();
            cmbCarreras = new ComboBox();
            cmbAsignaturas = new ComboBox();
            btnElegirCarrera = new Button();
            SuspendLayout();
            // 
            // btnEmpezarExamen
            // 
            btnEmpezarExamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezarExamen.Location = new Point(123, 192);
            btnEmpezarExamen.Name = "btnEmpezarExamen";
            btnEmpezarExamen.Size = new Size(150, 50);
            btnEmpezarExamen.TabIndex = 0;
            btnEmpezarExamen.Text = "Empezar examen";
            btnEmpezarExamen.UseVisualStyleBackColor = true;
            btnEmpezarExamen.Click += btnCargar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(428, 192);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 50);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblCarrera.Location = new Point(154, 81);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(78, 25);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblAsignatura.Location = new Point(123, 124);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Asignatura";
            // 
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI", 14.25F);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(238, 78);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(340, 33);
            cmbCarreras.TabIndex = 6;
            // 
            // cmbAsignaturas
            // 
            cmbAsignaturas.Font = new Font("Segoe UI", 14.25F);
            cmbAsignaturas.FormattingEnabled = true;
            cmbAsignaturas.Location = new Point(238, 124);
            cmbAsignaturas.Name = "cmbAsignaturas";
            cmbAsignaturas.Size = new Size(340, 33);
            cmbAsignaturas.TabIndex = 7;
            // 
            // btnElegirCarrera
            // 
            btnElegirCarrera.Location = new Point(546, 22);
            btnElegirCarrera.Name = "btnElegirCarrera";
            btnElegirCarrera.Size = new Size(150, 50);
            btnElegirCarrera.TabIndex = 8;
            btnElegirCarrera.Text = "Elegir asignatura";
            btnElegirCarrera.UseVisualStyleBackColor = true;
            btnElegirCarrera.Click += btnElegirCarrera_Click;
            // 
            // FrmCargaDatosExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 411);
            Controls.Add(btnElegirCarrera);
            Controls.Add(cmbAsignaturas);
            Controls.Add(cmbCarreras);
            Controls.Add(lblAsignatura);
            Controls.Add(lblCarrera);
            Controls.Add(btnVolver);
            Controls.Add(btnEmpezarExamen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCargaDatosExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Carrera y Asignatura";
            FormClosed += FrmCargaDatosExamen_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpezarExamen;
        private Button btnVolver;
        private Label lblCarrera;
        private Label lblAsignatura;
        private ComboBox cmbCarreras;
        private ComboBox cmbAsignaturas;
        private Button btnElegirCarrera;
    }
}