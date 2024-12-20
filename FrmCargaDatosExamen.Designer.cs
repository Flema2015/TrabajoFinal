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
            cmbCarrera = new ComboBox();
            cmbAsignatura = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // btnEmpezarExamen
            // 
            btnEmpezarExamen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezarExamen.Location = new Point(123, 333);
            btnEmpezarExamen.Name = "btnEmpezarExamen";
            btnEmpezarExamen.Size = new Size(150, 50);
            btnEmpezarExamen.TabIndex = 0;
            btnEmpezarExamen.Text = "Empezar examen";
            btnEmpezarExamen.UseVisualStyleBackColor = true;
            btnEmpezarExamen.Click += btnEmpezarExamen_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(428, 333);
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
            lblCarrera.Location = new Point(154, 175);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(78, 25);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblAsignatura.Location = new Point(123, 221);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Asignatura";
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(238, 172);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(340, 33);
            cmbCarrera.TabIndex = 6;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.Font = new Font("Segoe UI", 14.25F);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(238, 218);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(340, 33);
            cmbAsignatura.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(146, 82);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(146, 129);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(238, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 33);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(238, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(340, 33);
            txtApellido.TabIndex = 11;
            // 
            // FrmCargaDatosExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 411);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAsignatura);
            Controls.Add(cmbCarrera);
            Controls.Add(lblAsignatura);
            Controls.Add(lblCarrera);
            Controls.Add(btnVolver);
            Controls.Add(btnEmpezarExamen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCargaDatosExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Carrera y Asignatura";
            FormClosed += FrmCargaDatosExamen_FormClosed;
            Load += FrmCargaDatosExamen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpezarExamen;
        private Button btnVolver;
        private Label lblCarrera;
        private Label lblAsignatura;
        private ComboBox cmbCarrera;
        private ComboBox cmbAsignatura;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}