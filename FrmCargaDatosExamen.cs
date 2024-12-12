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
            using (FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen(cmbCarrera.SelectedItem.ToString(), cmbAsignatura.SelectedItem.ToString()))
            {
                frmRealizarExamen.ShowDialog();
                //frmRealizarExamen.Carrera = cmbCarrera.SelectedItem.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirCarrera_Click(object sender, EventArgs e)
        {
            cmbAsignatura.SelectedIndex = -1;
            cmbAsignatura.Items.Clear();

            cargarAsignatura();
        }

        private void FrmCargaDatosExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }

        private void cargarAsignatura()
        {

            if (cmbCarrera.Text == "Ing. en Sistemas")
            {
                cmbAsignatura.Items.Add("Matemática");
                cmbAsignatura.Items.Add("Programación");
                cmbAsignatura.Items.Add("Base de Datos");
            }

            if (cmbCarrera.Text == "LGTI")
            {
                cmbAsignatura.Items.Add("Programación");
                cmbAsignatura.Items.Add("Metodología de Desarrollo");
                cmbAsignatura.Items.Add("Lógica");
            }

            if (cmbCarrera.Text == "Lic. Videojuegos")
            {
                cmbAsignatura.Items.Add("Motores gráfico");
                cmbAsignatura.Items.Add("Programación");
                cmbAsignatura.Items.Add("Narrativa");
            }
        }
    }
}
