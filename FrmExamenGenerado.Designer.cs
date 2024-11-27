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
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // lstExamenGenerado
            // 
            lstExamenGenerado.FormattingEnabled = true;
            lstExamenGenerado.ItemHeight = 15;
            lstExamenGenerado.Location = new Point(83, 34);
            lstExamenGenerado.Name = "lstExamenGenerado";
            lstExamenGenerado.Size = new Size(632, 349);
            lstExamenGenerado.TabIndex = 0;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(361, 403);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            // 
            // FrmExamenRespuestasGeneradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(lstExamenGenerado);
            Name = "FrmExamenRespuestasGeneradas";
            Text = "Exámen Generado";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstExamenGenerado;
        private Button btnContinuar;
    }
}