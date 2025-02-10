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

   
        private void btnModificarBaja_Click(object sender, EventArgs e)
        {
            FrmModificarBajaPregunta frmModificarBajaPregunta = new FrmModificarBajaPregunta();
            frmModificarBajaPregunta.ShowDialog();
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
