namespace TrabajoFinal_
{
    partial class FrmModificarPregunta
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
            components = new System.ComponentModel.Container();
            btnModificar = new Button();
            btnCancelar = new Button();
            lblPreguntaID = new Label();
            label3 = new Label();
            lblRespuestas = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            lblSubUnidadModificar = new Label();
            btnModificarRespuesta = new Button();
            txtPregunta = new TextBox();
            txtSubUnidad = new TextBox();
            txtUnidad = new TextBox();
            txtAsignatura = new TextBox();
            txtRespuesta = new TextBox();
            label2 = new Label();
            btnBuscarIDpregunta = new Button();
            cmbCarrera = new ComboBox();
            label7 = new Label();
            cmbAsignatura = new ComboBox();
            lblAsignatura = new Label();
            lstPreguntas = new ListBox();
            txtCarrera = new TextBox();
            label8 = new Label();
            cmbRespuestas = new ComboBox();
            alertaVacio = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)alertaVacio).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(525, 476);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 50);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(693, 476);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPreguntaID
            // 
            lblPreguntaID.AutoSize = true;
            lblPreguntaID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreguntaID.ForeColor = SystemColors.ControlText;
            lblPreguntaID.Location = new Point(504, 12);
            lblPreguntaID.Name = "lblPreguntaID";
            lblPreguntaID.Size = new Size(93, 20);
            lblPreguntaID.TabIndex = 2;
            lblPreguntaID.Text = "ID Pregunta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(504, 151);
            label3.Name = "label3";
            label3.Size = new Size(181, 25);
            label3.TabIndex = 4;
            label3.Text = "Lista de Respuestas";
            // 
            // lblRespuestas
            // 
            lblRespuestas.AutoSize = true;
            lblRespuestas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuestas.Location = new Point(571, 187);
            lblRespuestas.Name = "lblRespuestas";
            lblRespuestas.Size = new Size(106, 25);
            lblRespuestas.TabIndex = 5;
            lblRespuestas.Text = "Respuesta ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 248);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 6;
            label5.Text = "Respuesta correcta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(566, 354);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 7;
            label6.Text = "Asignatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 397);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 8;
            label1.Text = "Unidad";
            // 
            // lblSubUnidadModificar
            // 
            lblSubUnidadModificar.AutoSize = true;
            lblSubUnidadModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubUnidadModificar.Location = new Point(554, 443);
            lblSubUnidadModificar.Name = "lblSubUnidadModificar";
            lblSubUnidadModificar.Size = new Size(120, 25);
            lblSubUnidadModificar.TabIndex = 9;
            lblSubUnidadModificar.Text = "Sub-Unidad";
            // 
            // btnModificarRespuesta
            // 
            btnModificarRespuesta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarRespuesta.Location = new Point(953, 176);
            btnModificarRespuesta.Name = "btnModificarRespuesta";
            btnModificarRespuesta.Size = new Size(150, 50);
            btnModificarRespuesta.TabIndex = 10;
            btnModificarRespuesta.Text = "Cargar respuesta";
            btnModificarRespuesta.UseVisualStyleBackColor = true;
            btnModificarRespuesta.Click += btnCargarRespuesta_Click;
            // 
            // txtPregunta
            // 
            txtPregunta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPregunta.Location = new Point(683, 102);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(250, 33);
            txtPregunta.TabIndex = 12;
            // 
            // txtSubUnidad
            // 
            txtSubUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubUnidad.Location = new Point(683, 440);
            txtSubUnidad.Name = "txtSubUnidad";
            txtSubUnidad.Size = new Size(264, 33);
            txtSubUnidad.TabIndex = 18;
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidad.Location = new Point(683, 394);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(264, 33);
            txtUnidad.TabIndex = 19;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsignatura.Location = new Point(683, 346);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(264, 33);
            txtAsignatura.TabIndex = 20;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRespuesta.Location = new Point(683, 184);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(264, 33);
            txtRespuesta.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 105);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Pregunta";
            // 
            // btnBuscarIDpregunta
            // 
            btnBuscarIDpregunta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarIDpregunta.Location = new Point(504, 41);
            btnBuscarIDpregunta.Name = "btnBuscarIDpregunta";
            btnBuscarIDpregunta.Size = new Size(150, 50);
            btnBuscarIDpregunta.TabIndex = 25;
            btnBuscarIDpregunta.Text = "Buscar preguntas";
            btnBuscarIDpregunta.UseVisualStyleBackColor = true;
            btnBuscarIDpregunta.Click += btnBuscarIDpregunta_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(123, 12);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(360, 33);
            cmbCarrera.TabIndex = 29;
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 28;
            label7.Text = "Carrera";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(123, 51);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(360, 33);
            cmbAsignatura.TabIndex = 27;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignatura.Location = new Point(8, 51);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(109, 25);
            lblAsignatura.TabIndex = 26;
            lblAsignatura.Text = "Asignatura";
            // 
            // lstPreguntas
            // 
            lstPreguntas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPreguntas.FormattingEnabled = true;
            lstPreguntas.ItemHeight = 17;
            lstPreguntas.Location = new Point(12, 90);
            lstPreguntas.Name = "lstPreguntas";
            lstPreguntas.Size = new Size(471, 429);
            lstPreguntas.TabIndex = 32;
            lstPreguntas.SelectedIndexChanged += lstPreguntas_SelectedIndexChanged;
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(683, 297);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(264, 33);
            txtCarrera.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(597, 297);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 33;
            label8.Text = "Carrera";
            // 
            // cmbRespuestas
            // 
            cmbRespuestas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRespuestas.FormattingEnabled = true;
            cmbRespuestas.Location = new Point(683, 245);
            cmbRespuestas.Name = "cmbRespuestas";
            cmbRespuestas.Size = new Size(264, 33);
            cmbRespuestas.TabIndex = 35;
            // 
            // alertaVacio
            // 
            alertaVacio.ContainerControl = this;
            // 
            // FrmModificarPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 533);
            Controls.Add(cmbRespuestas);
            Controls.Add(txtCarrera);
            Controls.Add(label8);
            Controls.Add(lstPreguntas);
            Controls.Add(cmbCarrera);
            Controls.Add(label7);
            Controls.Add(cmbAsignatura);
            Controls.Add(lblAsignatura);
            Controls.Add(btnBuscarIDpregunta);
            Controls.Add(txtRespuesta);
            Controls.Add(txtAsignatura);
            Controls.Add(txtUnidad);
            Controls.Add(txtSubUnidad);
            Controls.Add(txtPregunta);
            Controls.Add(btnModificarRespuesta);
            Controls.Add(lblSubUnidadModificar);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblRespuestas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPreguntaID);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificarPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarPregunta";
            Load += FrmModificarPregunta_Load;
            ((System.ComponentModel.ISupportInitialize)alertaVacio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnModificar;
        private Button btnCancelar;
        private Label lblPreguntaID;
        private Label label3;
        private Label lblRespuestas;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label lblSubUnidadModificar;
        private Button btnModificarRespuesta;
        private TextBox txtPregunta;
        private TextBox txtSubUnidad;
        private TextBox txtUnidad;
        private TextBox txtAsignatura;
        private TextBox txtRespuesta;
        private Label label2;
        private Button btnBuscarIDpregunta;
        private ComboBox cmbCarrera;
        private Label label7;
        private ComboBox cmbAsignatura;
        private Label lblAsignatura;
        private ListBox lstPreguntas;
        private TextBox txtCarrera;
        private Label label8;
        private ComboBox cmbRespuestas;
        private ErrorProvider alertaVacio;
    }
}