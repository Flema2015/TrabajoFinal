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
            btnAgregar = new Button();
            lblAsignatura = new Label();
            btnVolver = new Button();
            txtAsignatura = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            lstAsignaturas = new ListBox();
            label1 = new Label();
            lblUnidades = new Label();
            cmbUnidades = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(418, 369);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 50);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(418, 142);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 16;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(589, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 50);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsignatura.Location = new Point(418, 170);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(291, 33);
            txtAsignatura.TabIndex = 3;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(418, 37);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(78, 25);
            lblCarrera.TabIndex = 23;
            lblCarrera.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(418, 65);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(291, 33);
            txtCarrera.TabIndex = 2;
            // 
            // lstAsignaturas
            // 
            lstAsignaturas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAsignaturas.FormattingEnabled = true;
            lstAsignaturas.ItemHeight = 21;
            lstAsignaturas.Location = new Point(12, 37);
            lstAsignaturas.Name = "lstAsignaturas";
            lstAsignaturas.Size = new Size(400, 382);
            lstAsignaturas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 30;
            label1.Text = "Asignaturas";
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidades.Location = new Point(418, 249);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(205, 25);
            lblUnidades.TabIndex = 31;
            lblUnidades.Text = "Cantidad de unidades";
            // 
            // cmbUnidades
            // 
            cmbUnidades.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnidades.FormattingEnabled = true;
            cmbUnidades.Location = new Point(418, 277);
            cmbUnidades.Name = "cmbUnidades";
            cmbUnidades.Size = new Size(291, 33);
            cmbUnidades.TabIndex = 32;
            // 
            // FrmAdministrarAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(cmbUnidades);
            Controls.Add(lblUnidades);
            Controls.Add(label1);
            Controls.Add(lstAsignaturas);
            Controls.Add(txtCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtAsignatura);
            Controls.Add(btnAgregar);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarAsignatura";
            Text = "FrmAdministrarAsignatura";
            FormClosed += FrmAdministrarAsignatura_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Label lblAsignatura;
        private Button btnVolver;
        private TextBox txtAsignatura;
        private Label lblCarrera;
        private TextBox txtCarrera;
        private ListBox lstAsignaturas;
        private Label label1;
        private Label lblUnidades;
        private ComboBox cmbUnidades;
    }
}