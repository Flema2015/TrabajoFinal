namespace TrabajoFinal_
{
    partial class FrmGeneracionExm
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
            btnCancelar = new Button();
            cmbAsignatura = new ComboBox();
            SuspendLayout();
            // 
            // btnIrAExamen
            // 
            btnIrAExamen.Location = new Point(251, 224);
            btnIrAExamen.Name = "btnIrAExamen";
            btnIrAExamen.Size = new Size(98, 23);
            btnIrAExamen.TabIndex = 9;
            btnIrAExamen.Text = "Ir a Exámen";
            btnIrAExamen.UseVisualStyleBackColor = true;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(238, 142);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(383, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(367, 139);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(121, 23);
            cmbAsignatura.TabIndex = 11;
            // 
            // FrmGeneracionExm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(cmbAsignatura);
            Controls.Add(btnIrAExamen);
            Controls.Add(lblAsignatura);
            Controls.Add(btnCancelar);
            Name = "FrmGeneracionExm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generación de Exámenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Button btnIrAExamen;
        private Label lblAsignatura;
        private Button btnCancelar;
        private ComboBox cmbAsignatura;
    }
}