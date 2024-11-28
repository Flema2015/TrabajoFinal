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
    public partial class FrmExamenGenerado : Form
    {
        public FrmExamenGenerado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmGeneracionExm frmGeneracionExm = new FrmGeneracionExm();
            frmGeneracionExm.ShowDialog();
        }
    }
}
