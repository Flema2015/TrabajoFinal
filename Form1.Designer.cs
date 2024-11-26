namespace TrabajoFinal_
{
    partial class Form1
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
            btnRespuestas = new Button();
            btnCorregir = new Button();
            SuspendLayout();
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSistema.Location = new Point(230, 72);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(291, 25);
            lblSistema.TabIndex = 0;
            lblSistema.Text = "Sistema de Gestión de Exámenes:";
            // 
            // btnAdminBanco
            // 
            btnAdminBanco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminBanco.Location = new Point(183, 128);
            btnAdminBanco.Name = "btnAdminBanco";
            btnAdminBanco.Size = new Size(159, 57);
            btnAdminBanco.TabIndex = 1;
            btnAdminBanco.Text = "Administración del Banco de preguntas. ";
            btnAdminBanco.UseVisualStyleBackColor = true;
            btnAdminBanco.Click += btnAdminBanco_Click;
            // 
            // btnGenerarExm
            // 
            btnGenerarExm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarExm.Location = new Point(183, 219);
            btnGenerarExm.Name = "btnGenerarExm";
            btnGenerarExm.Size = new Size(159, 57);
            btnGenerarExm.TabIndex = 5;
            btnGenerarExm.Text = "Generación de Exámenes.";
            btnGenerarExm.UseVisualStyleBackColor = true;
            btnGenerarExm.Click += btnGenerarExm_Click;
            // 
            // btnRespuestas
            // 
            btnRespuestas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRespuestas.Location = new Point(395, 128);
            btnRespuestas.Name = "btnRespuestas";
            btnRespuestas.Size = new Size(159, 57);
            btnRespuestas.TabIndex = 6;
            btnRespuestas.Text = "Respuestas Exámen.";
            btnRespuestas.UseVisualStyleBackColor = true;
            btnRespuestas.Click += btnRespuestas_Click;
            // 
            // btnCorregir
            // 
            btnCorregir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorregir.Location = new Point(395, 219);
            btnCorregir.Name = "btnCorregir";
            btnCorregir.Size = new Size(159, 57);
            btnCorregir.TabIndex = 7;
            btnCorregir.Text = "Correción Exámenes.";
            btnCorregir.UseVisualStyleBackColor = true;
            btnCorregir.Click += btnCorregir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(btnCorregir);
            Controls.Add(btnRespuestas);
            Controls.Add(btnGenerarExm);
            Controls.Add(btnAdminBanco);
            Controls.Add(lblSistema);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSistema;
        private Button btnAdminBanco;
        private Button button4;
        private Button btnGenerarExm;
        private Button btnRespuestas;
        private Button btnCorregir;
    }
}
