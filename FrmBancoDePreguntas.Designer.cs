namespace TrabajoFinal_
{
    partial class FrmBancoDePreguntas
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
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(146, 133);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(90, 44);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Nueva Pregunta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(280, 133);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(90, 44);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(416, 133);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 44);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmBancoDePreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Name = "FrmBancoDePreguntas";
            Text = "Administración del banco de preguntas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
    }
}