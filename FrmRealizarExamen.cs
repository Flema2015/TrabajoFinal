namespace TrabajoFinal_
{
    public partial class FrmRealizarExamen : Form
    {
        public FrmRealizarExamen()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now.Date;
            lblFechaResolucion.Text = fecha.ToShortDateString();
        }

        private void btnEntregarExamen_Click(object sender, EventArgs e)
        {
            // Cierra este formulario y cualquier modal anterior
            this.DialogResult = DialogResult.OK; // Opcional para indicar éxito
            this.Close(); // Cierra el formulario actual
        }

        private void FrmRealizarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
