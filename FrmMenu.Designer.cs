namespace TrabajoFinal_
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSistema = new Label();
            btnAdminBanco = new Button();
            btnGenerarExm = new Button();
            btnRealizarExamen = new Button();
            btnCorregir = new Button();
            SuspendLayout();
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSistema.Location = new Point(209, 79);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(291, 25);
            lblSistema.TabIndex = 0;
            lblSistema.Text = "Sistema de Gestión de Exámenes:";
            // 
            // btnAdminBanco
            // 
            btnAdminBanco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminBanco.Location = new Point(173, 136);
            btnAdminBanco.Name = "btnAdminBanco";
            btnAdminBanco.Size = new Size(159, 57);
            btnAdminBanco.TabIndex = 1;
            btnAdminBanco.Text = "Administración del Banco de preguntas";
            btnAdminBanco.UseVisualStyleBackColor = true;
            btnAdminBanco.Click += btnAdminBanco_Click;
            // 
            // btnGenerarExm
            // 
            btnGenerarExm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarExm.Location = new Point(173, 227);
            btnGenerarExm.Name = "btnGenerarExm";
            btnGenerarExm.Size = new Size(159, 57);
            btnGenerarExm.TabIndex = 5;
            btnGenerarExm.Text = "Generación de Exámenes";
            btnGenerarExm.UseVisualStyleBackColor = true;
            btnGenerarExm.Click += btnGenerarExm_Click;
            // 
            // btnRealizarExamen
            // 
            btnRealizarExamen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRealizarExamen.Location = new Point(385, 136);
            btnRealizarExamen.Name = "btnRealizarExamen";
            btnRealizarExamen.Size = new Size(159, 57);
            btnRealizarExamen.TabIndex = 6;
            btnRealizarExamen.Text = "Realizar Exámen";
            btnRealizarExamen.UseVisualStyleBackColor = true;
            btnRealizarExamen.Click += btnRespuestas_Click;
            // 
            // btnCorregir
            // 
            btnCorregir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorregir.Location = new Point(385, 227);
            btnCorregir.Name = "btnCorregir";
            btnCorregir.Size = new Size(159, 57);
            btnCorregir.TabIndex = 7;
            btnCorregir.Text = "Correción Exámenes";
            btnCorregir.UseVisualStyleBackColor = true;
            btnCorregir.Click += btnCorregir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnCorregir);
            Controls.Add(btnRealizarExamen);
            Controls.Add(btnGenerarExm);
            Controls.Add(btnAdminBanco);
            Controls.Add(lblSistema);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Exámenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistema;
        private Button btnAdminBanco;
        private Button button4;
        private Button btnGenerarExm;
        private Button btnRealizarExamen;
        private Button btnCorregir;
    }
}
