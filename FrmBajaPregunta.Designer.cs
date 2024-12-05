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
            btnBorrar.Location = new Point(566, 137);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(84, 37);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(350, 362);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 37);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lstBaja
            // 
            lstBaja.FormattingEnabled = true;
            lstBaja.ItemHeight = 15;
            lstBaja.Location = new Point(24, 13);
            lstBaja.Name = "lstBaja";
            lstBaja.Size = new Size(465, 334);
            lstBaja.TabIndex = 2;
            // 
            // lblPreguntaABorrar
            // 
            lblPreguntaABorrar.AutoSize = true;
            lblPreguntaABorrar.Location = new Point(566, 56);
            lblPreguntaABorrar.Name = "lblPreguntaABorrar";
            lblPreguntaABorrar.Size = new Size(102, 15);
            lblPreguntaABorrar.TabIndex = 3;
            lblPreguntaABorrar.Text = "Pregunta a borrar:";
            // 
            // cmbPreguntaABorrar
            // 
            cmbPreguntaABorrar.FormattingEnabled = true;
            cmbPreguntaABorrar.Location = new Point(566, 93);
            cmbPreguntaABorrar.Name = "cmbPreguntaABorrar";
            cmbPreguntaABorrar.Size = new Size(121, 23);
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