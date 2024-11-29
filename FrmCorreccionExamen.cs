namespace TrabajoFinal_
{
    public partial class FrmCorreccionEx : Form
    {
        public FrmCorreccionEx()
        {
            InitializeComponent();
        }

        private void btnBuscarRespuestas_Click(object sender, EventArgs e)
        {
            FrmCompararRespuestas frmCompararRespuestas = new FrmCompararRespuestas();
            frmCompararRespuestas.ShowDialog();
        }

        private void btnVerDevolucion_Click(object sender, EventArgs e)
        {
            FrmVerDevolucion frmVerDevolucion = new FrmVerDevolucion();
            frmVerDevolucion.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
