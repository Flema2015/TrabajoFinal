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

        }
    }
}
