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
            btnAceptar = new Button();
            btnVolver = new Button();
            lblBorrarPregunta = new Label();
            txtBorrarPregunta = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(256, 291);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(373, 291);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblBorrarPregunta
            // 
            lblBorrarPregunta.AutoSize = true;
            lblBorrarPregunta.Location = new Point(227, 193);
            lblBorrarPregunta.Name = "lblBorrarPregunta";
            lblBorrarPregunta.Size = new Size(104, 15);
            lblBorrarPregunta.TabIndex = 2;
            lblBorrarPregunta.Text = "Borrar Pregunta ID";
            // 
            // txtBorrarPregunta
            // 
            txtBorrarPregunta.Location = new Point(373, 190);
            txtBorrarPregunta.Name = "txtBorrarPregunta";
            txtBorrarPregunta.Size = new Size(100, 23);
            txtBorrarPregunta.TabIndex = 3;
            // 
            // FrmBajaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(txtBorrarPregunta);
            Controls.Add(lblBorrarPregunta);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Name = "FrmBajaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BajaPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnVolver;
        private Label lblBorrarPregunta;
        private TextBox txtBorrarPregunta;
    }
}