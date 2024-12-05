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
            SuspendLayout();
            // 
            // btnIrAExamen
            // 
            btnIrAExamen.Location = new Point(214, 229);
            btnIrAExamen.Name = "btnIrAExamen";
            btnIrAExamen.Size = new Size(107, 23);
            btnIrAExamen.TabIndex = 9;
            btnIrAExamen.Text = "Generar Exámen";
            btnIrAExamen.UseVisualStyleBackColor = true;
            btnIrAExamen.Click += btnIrAExamen_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(214, 147);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(349, 229);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(324, 144);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(121, 23);
            cmbAsignatura.TabIndex = 11;
            // 
            // FrmAdministrarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
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
    }
}