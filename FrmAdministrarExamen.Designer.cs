namespace TrabajoFinal_
{
    partial class FrmAdministrarExamen
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
            btnIrAExamen = new Button();
            lblAsignatura = new Label();
            btnVolver = new Button();
            cmbAsignatura = new ComboBox();
            cmbUnidades = new ComboBox();
            lblUnidades = new Label();
            btnVerUltimoExamen = new Button();
            SuspendLayout();
            // 
            // btnIrAExamen
            // 
            btnIrAExamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrAExamen.Location = new Point(159, 229);
            btnIrAExamen.Name = "btnIrAExamen";
            btnIrAExamen.Size = new Size(150, 50);
            btnIrAExamen.TabIndex = 3;
            btnIrAExamen.Text = "Generar exámen";
            btnIrAExamen.UseVisualStyleBackColor = true;
            btnIrAExamen.Click += btnIrAExamen_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(76, 125);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(192, 25);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Carrera y asignatura";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(471, 229);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 50);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(274, 122);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(347, 33);
            cmbAsignatura.TabIndex = 1;
            // 
            // cmbUnidades
            // 
            cmbUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnidades.FormattingEnabled = true;
            cmbUnidades.Location = new Point(274, 168);
            cmbUnidades.Name = "cmbUnidades";
            cmbUnidades.Size = new Size(347, 33);
            cmbUnidades.TabIndex = 2;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidades.Location = new Point(173, 171);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(95, 25);
            lblUnidades.TabIndex = 12;
            lblUnidades.Text = "Unidades";
            // 
            // btnVerUltimoExamen
            // 
            btnVerUltimoExamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerUltimoExamen.Location = new Point(315, 229);
            btnVerUltimoExamen.Name = "btnVerUltimoExamen";
            btnVerUltimoExamen.Size = new Size(150, 50);
            btnVerUltimoExamen.TabIndex = 4;
            btnVerUltimoExamen.Text = "Último examen";
            btnVerUltimoExamen.UseVisualStyleBackColor = true;
            btnVerUltimoExamen.Click += btnVerUltimoExamen_Click;
            // 
            // FrmAdministrarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVerUltimoExamen);
            Controls.Add(cmbUnidades);
            Controls.Add(lblUnidades);
            Controls.Add(cmbAsignatura);
            Controls.Add(btnIrAExamen);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generación de Exámenes";
            FormClosed += FrmAdministrarExamen_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Button btnIrAExamen;
        private Label lblAsignatura;
        private Button btnVolver;
        private ComboBox cmbAsignatura;
        private ComboBox cmbUnidades;
        private Label lblUnidades;
        private Button btnVerUltimoExamen;
    }
}