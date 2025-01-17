namespace TrabajoFinal_
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
            btnVolver = new Button();
            lblIDExamen = new Label();
            txtDniAlumno = new TextBox();
            btnVerDevolucion = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(375, 194);
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
            lblIDExamen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDExamen.Location = new Point(206, 115);
            lblIDExamen.Name = "lblIDExamen";
            lblIDExamen.Size = new Size(93, 21);
            lblIDExamen.TabIndex = 2;
            lblIDExamen.Text = "Dni Alumno";
            // 
            // txtDniAlumno
            // 
            txtDniAlumno.Location = new Point(331, 117);
            txtDniAlumno.Name = "txtDniAlumno";
            txtDniAlumno.Size = new Size(100, 23);
            txtDniAlumno.TabIndex = 4;
            // 
            // btnVerDevolucion
            // 
            btnVerDevolucion.Location = new Point(199, 194);
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
            ClientSize = new Size(732, 411);
            Controls.Add(btnVerDevolucion);
            Controls.Add(txtDniAlumno);
            Controls.Add(lblIDExamen);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCorreccionEx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Corección de Exámenes";
            FormClosed += FrmCorreccionEx_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private Label lblIDExamen;
        private TextBox txtDniAlumno;
        private Button btnVerDevolucion;
    }
}