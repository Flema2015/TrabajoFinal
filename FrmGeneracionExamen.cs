namespace TrabajoFinal_
{
    public partial class FrmGeneracionExm : Form
    {
        public FrmGeneracionExm()
        {
            InitializeComponent();
            cmbAsignatura.DataSource = Enum.GetValues(typeof(Asignaturas));
        }

        public enum Asignaturas
        {
            ElegirMateria,
            Programación,
            Matemáticas
        }

        private void btnIrAExamen_Click(object sender, EventArgs e)
        {
            FrmExamenGenerado frmExamenGenerado = new FrmExamenGenerado();
            frmExamenGenerado.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
