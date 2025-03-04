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
            btnGenerarExamen = new Button();
            lblAsignatura = new Label();
            btnVolver = new Button();
            cmbAsignatura = new ComboBox();
            cmbUnidades = new ComboBox();
            lblUnidades = new Label();
            btnVerUltimoExamen = new Button();
            cmbCarrera = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarExamen.Location = new Point(147, 229);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(150, 50);
            btnGenerarExamen.TabIndex = 3;
            btnGenerarExamen.Text = "Generar exámen";
            btnGenerarExamen.UseVisualStyleBackColor = true;
            btnGenerarExamen.Click += btnGenerarExamen_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(147, 125);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(459, 229);
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
            cmbAsignatura.Location = new Point(262, 122);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(347, 33);
            cmbAsignatura.TabIndex = 1;
            // 
            // cmbUnidades
            // 
            cmbUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnidades.FormattingEnabled = true;
            cmbUnidades.Location = new Point(262, 160);
            cmbUnidades.Name = "cmbUnidades";
            cmbUnidades.Size = new Size(347, 33);
            cmbUnidades.TabIndex = 2;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidades.Location = new Point(161, 163);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(95, 25);
            lblUnidades.TabIndex = 12;
            lblUnidades.Text = "Unidades";
            // 
            // btnVerUltimoExamen
            // 
            btnVerUltimoExamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerUltimoExamen.Location = new Point(303, 229);
            btnVerUltimoExamen.Name = "btnVerUltimoExamen";
            btnVerUltimoExamen.Size = new Size(150, 50);
            btnVerUltimoExamen.TabIndex = 4;
            btnVerUltimoExamen.Text = "Últimos exámenes generados";
            btnVerUltimoExamen.UseVisualStyleBackColor = true;
            btnVerUltimoExamen.Click += btnVerUltimoExamen_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(262, 83);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(347, 33);
            cmbCarrera.TabIndex = 13;
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 86);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 14;
            label1.Text = "Carrera";
            // 
            // FrmAdministrarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(cmbCarrera);
            Controls.Add(label1);
            Controls.Add(btnVerUltimoExamen);
            Controls.Add(cmbUnidades);
            Controls.Add(lblUnidades);
            Controls.Add(cmbAsignatura);
            Controls.Add(btnGenerarExamen);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generación de Exámenes";
            FormClosed += FrmAdministrarExamen_FormClosed;
            Load += FrmAdministrarExamen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Button btnGenerarExamen;
        private Label lblAsignatura;
        private Button btnVolver;
        private ComboBox cmbAsignatura;
        private ComboBox cmbUnidades;
        private Label lblUnidades;
        private Button btnVerUltimoExamen;
        private ComboBox cmbCarrera;
        private Label label1;
    }
}