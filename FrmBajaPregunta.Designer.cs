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
            btnCancelar = new Button();
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
            // btnCancelar
            // 
            btnCancelar.Location = new Point(373, 291);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(800, 450);
            Controls.Add(txtBorrarPregunta);
            Controls.Add(lblBorrarPregunta);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmBajaPregunta";
            Text = "BajaPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblBorrarPregunta;
        private TextBox txtBorrarPregunta;
    }
}