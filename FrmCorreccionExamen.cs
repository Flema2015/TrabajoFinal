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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }
    }
}
