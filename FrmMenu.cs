namespace TrabajoFinal_
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

        }

        private void btnAdminBanco_Click(object sender, EventArgs e)
        {
            FrmBancoDePreguntas frmBancoPreguntas = new FrmBancoDePreguntas();
            frmBancoPreguntas.ShowDialog();
        }
        private void btnGenerarExm_Click(object sender, EventArgs e)
        {
            FrmGeneracionExm frmGeneracionExm = new FrmGeneracionExm();
            frmGeneracionExm.Visible = true;
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            FrmCargaDatosExamen frmCargaDatosExamen = new FrmCargaDatosExamen();
            frmCargaDatosExamen.Visible = true;
        }


        private void btnCorregir_Click(object sender, EventArgs e)
        {
            FrmCorreccionEx frmCorreccionEx = new FrmCorreccionEx();
            frmCorreccionEx.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
