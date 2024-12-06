namespace TrabajoFinal_
{
    partial class FrmBajaPregunta
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
            btnBorrar = new Button();
            btnVolver = new Button();
            lstBaja = new ListBox();
            lblPreguntaABorrar = new Label();
            cmbPreguntaABorrar = new ComboBox();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.White;
            btnBorrar.FlatAppearance.BorderColor = Color.Black;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(524, 94);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 50);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.FlatAppearance.BorderColor = Color.Black;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(524, 342);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 50);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lstBaja
            // 
            lstBaja.FormattingEnabled = true;
            lstBaja.ItemHeight = 15;
            lstBaja.Location = new Point(24, 13);
            lstBaja.Name = "lstBaja";
            lstBaja.Size = new Size(465, 379);
            lstBaja.TabIndex = 2;
            // 
            // lblPreguntaABorrar
            // 
            lblPreguntaABorrar.AutoSize = true;
            lblPreguntaABorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaABorrar.Location = new Point(508, 13);
            lblPreguntaABorrar.Name = "lblPreguntaABorrar";
            lblPreguntaABorrar.Size = new Size(173, 25);
            lblPreguntaABorrar.TabIndex = 3;
            lblPreguntaABorrar.Text = "Pregunta a borrar";
            // 
            // cmbPreguntaABorrar
            // 
            cmbPreguntaABorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPreguntaABorrar.FormattingEnabled = true;
            cmbPreguntaABorrar.Location = new Point(508, 50);
            cmbPreguntaABorrar.Name = "cmbPreguntaABorrar";
            cmbPreguntaABorrar.Size = new Size(179, 33);
            cmbPreguntaABorrar.TabIndex = 4;
            // 
            // FrmBajaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(cmbPreguntaABorrar);
            Controls.Add(lblPreguntaABorrar);
            Controls.Add(lstBaja);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBajaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BajaPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnVolver;
        private ListBox lstBaja;
        private Label lblPreguntaABorrar;
        private ComboBox cmbPreguntaABorrar;
    }
}