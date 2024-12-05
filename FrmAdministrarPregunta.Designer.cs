namespace TrabajoFinal_
{
    partial class FrmAdministrarPregunta
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
            btnVolverAlMenu = new Button();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(178, 150);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(90, 44);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Nueva Pregunta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(312, 150);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(90, 44);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(448, 150);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 44);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.Location = new Point(312, 245);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(90, 44);
            btnVolverAlMenu.TabIndex = 3;
            btnVolverAlMenu.Text = "Volver al menu";
            btnVolverAlMenu.UseVisualStyleBackColor = true;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // FrmAdministrarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdministrarPregunta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar preguntas";
            FormClosed += this.FrmAdministrarPregunta_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnVolverAlMenu;
    }
}