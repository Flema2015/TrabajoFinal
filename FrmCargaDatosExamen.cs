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

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }
    }
}
