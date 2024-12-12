namespace TrabajoFinal_
{
    partial class FrmAdministrarAsignatura
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
            lblAsignatura = new Label();
            btnVolver = new Button();
            txtAsginatura = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(197, 225);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 23);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(224, 170);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(80, 20);
            lblAsignatura.TabIndex = 16;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(393, 225);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtAsginatura
            // 
            txtAsginatura.Location = new Point(336, 171);
            txtAsginatura.Name = "txtAsginatura";
            txtAsginatura.Size = new Size(125, 23);
            txtAsginatura.TabIndex = 20;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(224, 128);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 23;
            lblCarrera.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(336, 125);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(125, 23);
            txtCarrera.TabIndex = 24;
            // 
            // FrmAdministrarAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(txtCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtAsginatura);
            Controls.Add(btnAceptar);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolver);
            Name = "FrmAdministrarAsignatura";
            Text = "FrmAdministrarAsignatura";
            FormClosed += FrmAdministrarAsignatura_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Label lblAsignatura;
        private Button btnVolver;
        private TextBox txtAsginatura;
        private Label lblCarrera;
        private TextBox txtCarrera;
    }
}