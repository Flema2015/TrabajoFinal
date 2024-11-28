using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }

        private void btnIrAExamen_Click(object sender, EventArgs e)
        {
            FrmExamenGenerado frmExamenGenerado = new FrmExamenGenerado();
            frmExamenGenerado.ShowDialog();
        }
    }
}
