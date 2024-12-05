using System.Windows.Forms;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarExamen : Form
    {
        public FrmAdministrarExamen()
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

        private void FrmAdministrarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }
    }
}
