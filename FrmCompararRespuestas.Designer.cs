namespace TrabajoFinal_
{
    partial class FrmCompararRespuestas
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
            btnCorregir = new Button();
            btnVolver = new Button();
            lblRespuestasCorrectas = new Label();
            lblRespuestasUsuario = new Label();
            lstRespuestasCorrectas = new ListBox();
            lstRespuestasUsuario = new ListBox();
            lblResultado = new Label();
            txtResultado = new TextBox();
            lblDevolucion = new Label();
            lstDevolucion = new ListBox();
            SuspendLayout();
            // 
            // btnCorregir
            // 
            btnCorregir.Location = new Point(285, 415);
            btnCorregir.Name = "btnCorregir";
            btnCorregir.Size = new Size(75, 23);
            btnCorregir.TabIndex = 0;
            btnCorregir.Text = "Corregir";
            btnCorregir.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(410, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblRespuestasCorrectas
            // 
            lblRespuestasCorrectas.AutoSize = true;
            lblRespuestasCorrectas.Location = new Point(33, 36);
            lblRespuestasCorrectas.Name = "lblRespuestasCorrectas";
            lblRespuestasCorrectas.Size = new Size(118, 15);
            lblRespuestasCorrectas.TabIndex = 2;
            lblRespuestasCorrectas.Text = "Respuestas Correctas";
            // 
            // lblRespuestasUsuario
            // 
            lblRespuestasUsuario.AutoSize = true;
            lblRespuestasUsuario.Location = new Point(178, 36);
            lblRespuestasUsuario.Name = "lblRespuestasUsuario";
            lblRespuestasUsuario.Size = new Size(124, 15);
            lblRespuestasUsuario.TabIndex = 3;
            lblRespuestasUsuario.Text = "Respuestas de Usuario";
            // 
            // lstRespuestasCorrectas
            // 
            lstRespuestasCorrectas.FormattingEnabled = true;
            lstRespuestasCorrectas.ItemHeight = 15;
            lstRespuestasCorrectas.Location = new Point(33, 80);
            lstRespuestasCorrectas.Name = "lstRespuestasCorrectas";
            lstRespuestasCorrectas.Size = new Size(120, 139);
            lstRespuestasCorrectas.TabIndex = 4;
            // 
            // lstRespuestasUsuario
            // 
            lstRespuestasUsuario.FormattingEnabled = true;
            lstRespuestasUsuario.ItemHeight = 15;
            lstRespuestasUsuario.Location = new Point(182, 80);
            lstRespuestasUsuario.Name = "lstRespuestasUsuario";
            lstRespuestasUsuario.Size = new Size(120, 139);
            lstRespuestasUsuario.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(410, 80);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(499, 77);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 7;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.Location = new Point(410, 127);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(67, 15);
            lblDevolucion.TabIndex = 8;
            lblDevolucion.Text = "Devolucion";
            // 
            // lstDevolucion
            // 
            lstDevolucion.FormattingEnabled = true;
            lstDevolucion.ItemHeight = 15;
            lstDevolucion.Location = new Point(499, 127);
            lstDevolucion.Name = "lstDevolucion";
            lstDevolucion.Size = new Size(204, 139);
            lstDevolucion.TabIndex = 9;
            // 
            // FrmCompararRespuestas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDevolucion);
            Controls.Add(lblDevolucion);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(lstRespuestasUsuario);
            Controls.Add(lstRespuestasCorrectas);
            Controls.Add(lblRespuestasUsuario);
            Controls.Add(lblRespuestasCorrectas);
            Controls.Add(btnVolver);
            Controls.Add(btnCorregir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCompararRespuestas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompararRespuestas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCorregir;
        private Button btnVolver;
        private Label lblRespuestasCorrectas;
        private Label lblRespuestasUsuario;
        private ListBox lstRespuestasCorrectas;
        private ListBox lstRespuestasUsuario;
        private Label lblResultado;
        private TextBox txtResultado;
        private Label lblDevolucion;
        private ListBox lstDevolucion;
    }
}