namespace TrabajoFinal_
{
    public partial class FrmAdministrarPregunta : Form
    {
        public FrmAdministrarPregunta()
        {
            InitializeComponent();
        }

        // Evento para restaurar el menú al cerrar el formulario hijo
        private void FrmAdministrarPregunta_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            using (FrmAltaPregunta frmAltaPregunta = new FrmAltaPregunta())
            {
                frmAltaPregunta.ShowDialog();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FrmBajaPregunta frmBajaPregunta = new FrmBajaPregunta();
            frmBajaPregunta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPregunta frmModificarPregunta = new FrmModificarPregunta();
            frmModificarPregunta.ShowDialog();
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
