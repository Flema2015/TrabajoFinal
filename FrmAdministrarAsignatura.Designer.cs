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
            txtNombre = new TextBox();
            lblCarrera = new Label();
            lstAsignaturas = new ListBox();
            label1 = new Label();
            lblUnidades = new Label();
            cmbUnidades = new ComboBox();
            cmbCarreras = new ComboBox();
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
            lblAsignatura.Location = new Point(418, 38);
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
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(418, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 33);
            txtNombre.TabIndex = 3;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(418, 128);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(78, 25);
            lblCarrera.TabIndex = 23;
            lblCarrera.Text = "Carrera";
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
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(418, 156);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(291, 33);
            cmbCarreras.TabIndex = 33;
            // 
            // FrmAdministrarAsignatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(cmbCarreras);
            Controls.Add(cmbUnidades);
            Controls.Add(lblUnidades);
            Controls.Add(label1);
            Controls.Add(lstAsignaturas);
            Controls.Add(lblCarrera);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministrarAsignatura";
            Text = "FrmAdministrarAsignatura";
            FormClosed += FrmAdministrarAsignatura_FormClosed;
            Load += FrmAdministrarAsignatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Label lblAsignatura;
        private Button btnVolver;
        private TextBox txtNombre;
        private Label lblCarrera;
        private ListBox lstAsignaturas;
        private Label label1;
        private Label lblUnidades;
        private ComboBox cmbUnidades;
        private ComboBox cmbCarreras;
    }
}