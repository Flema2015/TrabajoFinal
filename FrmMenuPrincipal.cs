namespace TrabajoFinal_
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // Ocultar el menú usando la clase estática
            GestorMenu.OcultarMenu();

            // Configurar el formulario hijo como hijo del MDI
            formularioHijo.MdiParent = this;
            //formularioHijo.FormClosed += FormularioHijo_FormClosed;
            formularioHijo.Show();
        }

        private void administrarPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarPregunta frmAdministrarPreguntas = new FrmAdministrarPregunta();
            AbrirFormularioHijo(frmAdministrarPreguntas);

            /*
            FrmAdministrarPregunta frmAdministrarPreguntas = new FrmAdministrarPregunta();
            frmAdministrarPreguntas.MdiParent = this;
            menuStrip1.Visible = false;
            frmAdministrarPreguntas.Show();
            */
        }

        private void administrarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarExamen frmAdministrarExamen = new FrmAdministrarExamen();
            AbrirFormularioHijo(frmAdministrarExamen);
        }
        private void realizarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen();
            AbrirFormularioHijo(frmRealizarExamen);
        }
        private void correcciónDeExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCorreccionEx frmCorreccionEx = new FrmCorreccionEx();
            AbrirFormularioHijo(frmCorreccionEx);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Asignar el menú principal a la clase estática
            GestorMenu.MenuPrincipal = menuStrip1;
        }


    }
}
