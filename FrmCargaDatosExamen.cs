namespace TrabajoFinal_
{
    public partial class FrmCargaDatosExamen : Form
    {
        public FrmCargaDatosExamen()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen();
            frmRealizarExamen.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
