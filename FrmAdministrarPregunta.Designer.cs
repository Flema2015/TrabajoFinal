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
            btnModificarBaja = new Button();
            btnVolverAlMenu = new Button();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.White;
            btnAlta.FlatAppearance.BorderColor = Color.Black;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.Location = new Point(184, 146);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(150, 50);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Nueva pregunta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificarBaja
            // 
            btnModificarBaja.BackColor = Color.White;
            btnModificarBaja.FlatAppearance.BorderColor = Color.Black;
            btnModificarBaja.FlatAppearance.BorderSize = 0;
            btnModificarBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnModificarBaja.FlatStyle = FlatStyle.Flat;
            btnModificarBaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarBaja.Location = new Point(407, 146);
            btnModificarBaja.Name = "btnModificarBaja";
            btnModificarBaja.Size = new Size(150, 50);
            btnModificarBaja.TabIndex = 2;
            btnModificarBaja.Text = "Modificar/Baja";
            btnModificarBaja.UseVisualStyleBackColor = false;
            btnModificarBaja.Click += btnModificarBaja_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.White;
            btnVolverAlMenu.FlatAppearance.BorderColor = Color.Black;
            btnVolverAlMenu.FlatAppearance.BorderSize = 0;
            btnVolverAlMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnVolverAlMenu.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverAlMenu.Location = new Point(294, 239);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(150, 50);
            btnVolverAlMenu.TabIndex = 3;
            btnVolverAlMenu.Text = "Volver";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // FrmAdministrarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnVolverAlMenu);
            Controls.Add(btnModificarBaja);
            Controls.Add(btnAlta);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdministrarPregunta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar preguntas";
            FormClosed += FrmAdministrarPregunta_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlta;
        private Button btnModificarBaja;
        private Button btnVolverAlMenu;
    }
}