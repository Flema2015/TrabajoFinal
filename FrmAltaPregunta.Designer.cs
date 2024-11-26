namespace TrabajoFinal_
{
    partial class FrmAltaPregunta
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
            txtPreguntaId = new TextBox();
            lblPreguntaId = new Label();
            lblPregunta = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            txtRespuesta = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            cmbRespuestas = new ComboBox();
            btnCargar = new Button();
            lblRespuesta = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtPreguntaId
            // 
            txtPreguntaId.Location = new Point(120, 60);
            txtPreguntaId.Name = "txtPreguntaId";
            txtPreguntaId.Size = new Size(100, 23);
            txtPreguntaId.TabIndex = 0;
            // 
            // lblPreguntaId
            // 
            lblPreguntaId.AutoSize = true;
            lblPreguntaId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaId.Location = new Point(12, 59);
            lblPreguntaId.Name = "lblPreguntaId";
            lblPreguntaId.Size = new Size(87, 20);
            lblPreguntaId.TabIndex = 2;
            lblPreguntaId.Text = "PreguntaId";
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(12, 100);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(73, 20);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "Pregunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 4;
            label2.Text = "Lista De Respuestas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 251);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 5;
            label3.Text = "Respuesta Correcta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 292);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Asignatura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 337);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 7;
            label5.Text = "Unidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 374);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 8;
            label6.Text = "Sub Unidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(134, 191);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(100, 23);
            txtRespuesta.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(120, 337);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(120, 375);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 14;
            // 
            // cmbRespuestas
            // 
            cmbRespuestas.FormattingEnabled = true;
            cmbRespuestas.Location = new Point(378, 188);
            cmbRespuestas.Name = "cmbRespuestas";
            cmbRespuestas.Size = new Size(121, 23);
            cmbRespuestas.TabIndex = 15;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(260, 182);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 41);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "Cargar Respuestas";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(12, 191);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(107, 20);
            lblRespuesta.TabIndex = 17;
            lblRespuesta.Text = "Respuesta #1:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(278, 374);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 29);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblRespuesta);
            Controls.Add(btnCargar);
            Controls.Add(cmbRespuestas);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtRespuesta);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPregunta);
            Controls.Add(lblPreguntaId);
            Controls.Add(txtPreguntaId);
            Name = "FrmAltaPregunta";
            Text = "FrmAltaPregunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPreguntaId;
        private Label lblPreguntaId;
        private Label lblPregunta;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtRespuesta;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox cmbRespuestas;
        private Button btnCargar;
        private Label lblRespuesta;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}