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
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(214, 362);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(84, 37);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(407, 362);
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
            lstBaja.Size = new Size(685, 334);
            lstBaja.TabIndex = 2;
            lstBaja.SelectedIndexChanged += lstBaja_SelectedIndexChanged;
            // 
            // FrmBajaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(lstBaja);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Name = "FrmBajaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BajaPregunta";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrar;
        private Button btnVolver;
        private ListBox lstBaja;
    }
}