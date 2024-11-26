namespace TrabajoFinal_
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdminBanco_Click(object sender, EventArgs e)
        {
            FrmBancoDePreguntas ventana = new FrmBancoDePreguntas();
            ventana.Visible = true;
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            FrmRespuestaEx ventana = new FrmRespuestaEx();
            ventana.Visible = true;
        }

        private void btnGenerarExm_Click(object sender, EventArgs e)
        {
            FrmGeneracionExm ventana = new FrmGeneracionExm();
            ventana.Visible = true;
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            FrmCorreccionEx ventana = new FrmCorreccionEx();
            ventana.Visible = true;
        }
    }
}
