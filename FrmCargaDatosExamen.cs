namespace TrabajoFinal_
{
    public partial class FrmCargaDatosExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        private List<Examen> examenes = new List<Examen>();
        public FrmCargaDatosExamen()
        {
            InitializeComponent();
            cmbCarrera.Items.Add("Ing. en Sistemas");
            cmbCarrera.Items.Add("LGTI");
            cmbCarrera.Items.Add("Lic. Videojuegos");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen())
            {
                frmRealizarExamen.ShowDialog();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarAsignatura()
        {
            if (cmbCarrera.Text == "Ing. en Sistemas")
            {
                cmbAsignatura.Items.Add("historia");
            }

            if (cmbCarrera.Text == "LGTI")
            {
                cmbAsignatura.Items.Add("historia");
            }

            if (cmbCarrera.Text == "Lic. Videojuegos")
            {
                cmbAsignatura.Items.Add("historia");
            }
        }

        private void btnElegirCarrera_Click(object sender, EventArgs e)
        {
            cmbAsignatura.SelectedIndex = -1;
            cmbAsignatura.Items.Clear();
            cargarAsignatura();
            
        }
    }
}
