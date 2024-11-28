namespace TrabajoFinal_
{
    partial class FrmExamenGenerado
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
            lstExamenGenerado = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lstExamenGenerado
            // 
            lstExamenGenerado.FormattingEnabled = true;
            lstExamenGenerado.ItemHeight = 15;
            lstExamenGenerado.Location = new Point(48, 12);
            lstExamenGenerado.Name = "lstExamenGenerado";
            lstExamenGenerado.Size = new Size(632, 349);
            lstExamenGenerado.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(327, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmExamenGenerado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVolver);
            Controls.Add(lstExamenGenerado);
            Name = "FrmExamenGenerado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exámen Generado";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstExamenGenerado;
        private Button btnVolver;
    }
}