namespace TrabajoFinal_
{
    partial class FrmGeneracionExm
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
            Aceptar = new Button();
            btnGenerarRespuestas = new Button();
            txtAsignatura = new TextBox();
            lblAsignatura = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(265, 306);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 10;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarRespuestas
            // 
            btnGenerarRespuestas.Location = new Point(332, 205);
            btnGenerarRespuestas.Name = "btnGenerarRespuestas";
            btnGenerarRespuestas.Size = new Size(75, 38);
            btnGenerarRespuestas.TabIndex = 9;
            btnGenerarRespuestas.Text = "Generar Exámen";
            btnGenerarRespuestas.UseVisualStyleBackColor = true;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(404, 147);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(100, 23);
            txtAsignatura.TabIndex = 8;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(261, 147);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(404, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmGeneracionExm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Aceptar);
            Controls.Add(btnGenerarRespuestas);
            Controls.Add(txtAsignatura);
            Controls.Add(lblAsignatura);
            Controls.Add(btnCancelar);
            Name = "FrmGeneracionExm";
            Text = "Generación de Exámenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Button btnGenerarRespuestas;
        private TextBox txtAsignatura;
        private Label lblAsignatura;
        private Button btnCancelar;
    }
}