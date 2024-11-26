namespace TrabajoFinal_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminBanco_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Visible = true;
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Visible = true;
        }

        private void btnGenerarExm_Click(object sender, EventArgs e)
        {
            Form4 ventana = new Form4();
            ventana.Visible = true;
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            Form5 ventana = new Form5();
            ventana.Visible = true;
        }
    }
}
