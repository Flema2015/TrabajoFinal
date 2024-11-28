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
    public partial class FrmRealizarExamen : Form
    {
        public FrmRealizarExamen()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now.Date;
            lblFechaResolucion.Text = fecha.ToShortDateString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmCargaDatosExamen frmCargaDatosExamen = new FrmCargaDatosExamen();
            frmCargaDatosExamen.ShowDialog();
        }
    }
}
