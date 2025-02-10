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
            btnVolver = new Button();
            lblRespuestasCorrectas = new Label();
            lblRespuestasUsuario = new Label();
            lstRespuestasCorrectas = new ListBox();
            lstRespuestasUsuario = new ListBox();
            lblResultado = new Label();
            lblResultadoNum = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(351, 415);
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
            lblRespuestasCorrectas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespuestasCorrectas.Location = new Point(323, 9);
            lblRespuestasCorrectas.Name = "lblRespuestasCorrectas";
            lblRespuestasCorrectas.Size = new Size(148, 20);
            lblRespuestasCorrectas.TabIndex = 2;
            lblRespuestasCorrectas.Text = "Respuestas Correctas";
            // 
            // lblRespuestasUsuario
            // 
            lblRespuestasUsuario.AutoSize = true;
            lblRespuestasUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespuestasUsuario.Location = new Point(323, 174);
            lblRespuestasUsuario.Name = "lblRespuestasUsuario";
            lblRespuestasUsuario.Size = new Size(157, 20);
            lblRespuestasUsuario.TabIndex = 3;
            lblRespuestasUsuario.Text = "Respuestas de Usuario";
            // 
            // lstRespuestasCorrectas
            // 
            lstRespuestasCorrectas.FormattingEnabled = true;
            lstRespuestasCorrectas.ItemHeight = 15;
            lstRespuestasCorrectas.Location = new Point(225, 32);
            lstRespuestasCorrectas.Name = "lstRespuestasCorrectas";
            lstRespuestasCorrectas.Size = new Size(376, 139);
            lstRespuestasCorrectas.TabIndex = 4;
            // 
            // lstRespuestasUsuario
            // 
            lstRespuestasUsuario.FormattingEnabled = true;
            lstRespuestasUsuario.ItemHeight = 15;
            lstRespuestasUsuario.Location = new Point(225, 197);
            lstRespuestasUsuario.Name = "lstRespuestasUsuario";
            lstRespuestasUsuario.Size = new Size(376, 139);
            lstRespuestasUsuario.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(333, 351);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 21);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // lblResultadoNum
            // 
            lblResultadoNum.AutoSize = true;
            lblResultadoNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoNum.Location = new Point(418, 351);
            lblResultadoNum.Name = "lblResultadoNum";
            lblResultadoNum.Size = new Size(19, 21);
            lblResultadoNum.TabIndex = 10;
            lblResultadoNum.Text = "0";
            // 
            // FrmCompararRespuestas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoNum);
            Controls.Add(lblResultado);
            Controls.Add(lstRespuestasUsuario);
            Controls.Add(lstRespuestasCorrectas);
            Controls.Add(lblRespuestasUsuario);
            Controls.Add(lblRespuestasCorrectas);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCompararRespuestas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCompararRespuestas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolver;
        private Label lblRespuestasCorrectas;
        private Label lblRespuestasUsuario;
        private ListBox lstRespuestasCorrectas;
        private ListBox lstRespuestasUsuario;
        private Label lblResultado;
        private Label lblResultadoNum;
    }
}