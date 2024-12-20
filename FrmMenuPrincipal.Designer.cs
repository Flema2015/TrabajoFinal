namespace TrabajoFinal_
{
    partial class FrmMenuPrincipal
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            administrarCarrerasToolStripMenuItem = new ToolStripMenuItem();
            administrarAsignaturasToolStripMenuItem = new ToolStripMenuItem();
            administrarPreguntasToolStripMenuItem = new ToolStripMenuItem();
            administrarExamenToolStripMenuItem = new ToolStripMenuItem();
            realizarExamenToolStripMenuItem = new ToolStripMenuItem();
            correcciónDeExamenToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(754, 29);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarCarrerasToolStripMenuItem, administrarAsignaturasToolStripMenuItem, administrarPreguntasToolStripMenuItem, administrarExamenToolStripMenuItem, realizarExamenToolStripMenuItem, correcciónDeExamenToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 25);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // administrarCarrerasToolStripMenuItem
            // 
            administrarCarrerasToolStripMenuItem.Name = "administrarCarrerasToolStripMenuItem";
            administrarCarrerasToolStripMenuItem.Size = new Size(246, 26);
            administrarCarrerasToolStripMenuItem.Text = "Administrar carreras";
            administrarCarrerasToolStripMenuItem.Click += administrarCarrerasToolStripMenuItem_Click;
            // 
            // administrarAsignaturasToolStripMenuItem
            // 
            administrarAsignaturasToolStripMenuItem.Name = "administrarAsignaturasToolStripMenuItem";
            administrarAsignaturasToolStripMenuItem.Size = new Size(246, 26);
            administrarAsignaturasToolStripMenuItem.Text = "Administrar asignaturas";
            administrarAsignaturasToolStripMenuItem.Click += administrarAsignaturasToolStripMenuItem_Click;
            // 
            // administrarPreguntasToolStripMenuItem
            // 
            administrarPreguntasToolStripMenuItem.Name = "administrarPreguntasToolStripMenuItem";
            administrarPreguntasToolStripMenuItem.Size = new Size(246, 26);
            administrarPreguntasToolStripMenuItem.Text = "Administrar preguntas";
            administrarPreguntasToolStripMenuItem.Click += administrarPreguntasToolStripMenuItem_Click;
            // 
            // administrarExamenToolStripMenuItem
            // 
            administrarExamenToolStripMenuItem.Name = "administrarExamenToolStripMenuItem";
            administrarExamenToolStripMenuItem.Size = new Size(246, 26);
            administrarExamenToolStripMenuItem.Text = "Administrar examen";
            administrarExamenToolStripMenuItem.Click += administrarExamenToolStripMenuItem_Click;
            // 
            // realizarExamenToolStripMenuItem
            // 
            realizarExamenToolStripMenuItem.Name = "realizarExamenToolStripMenuItem";
            realizarExamenToolStripMenuItem.Size = new Size(246, 26);
            realizarExamenToolStripMenuItem.Text = "Realizar examen";
            realizarExamenToolStripMenuItem.Click += realizarExamenToolStripMenuItem_Click;
            // 
            // correcciónDeExamenToolStripMenuItem
            // 
            correcciónDeExamenToolStripMenuItem.Name = "correcciónDeExamenToolStripMenuItem";
            correcciónDeExamenToolStripMenuItem.Size = new Size(246, 26);
            correcciónDeExamenToolStripMenuItem.Text = "Corrección de examen";
            correcciónDeExamenToolStripMenuItem.Click += correcciónDeExamenToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(246, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 446);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Exámenes";
            Load += FrmMenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem administrarPreguntasToolStripMenuItem;
        private ToolStripMenuItem administrarExamenToolStripMenuItem;
        private ToolStripMenuItem realizarExamenToolStripMenuItem;
        private ToolStripMenuItem correcciónDeExamenToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem administrarAsignaturasToolStripMenuItem;
        private ToolStripMenuItem administrarCarrerasToolStripMenuItem;
    }
}
