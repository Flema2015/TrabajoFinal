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
            btnAlta.BackColor = Color.White;
            btnAlta.FlatAppearance.BorderColor = Color.Black;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.Location = new Point(125, 146);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(150, 50);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Nueva pregunta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.White;
            btnBaja.FlatAppearance.BorderColor = Color.Black;
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.Location = new Point(292, 146);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(150, 50);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(458, 146);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 50);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.White;
            btnVolverAlMenu.FlatAppearance.BorderColor = Color.Black;
            btnVolverAlMenu.FlatAppearance.BorderSize = 0;
            btnVolverAlMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnVolverAlMenu.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverAlMenu.Location = new Point(292, 261);
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
            FormClosed += FrmAdministrarPregunta_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnVolverAlMenu;
    }
}