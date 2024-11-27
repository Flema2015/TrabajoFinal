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
    public partial class FrmBancoDePreguntas : Form
    {
        public FrmBancoDePreguntas()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAltaPregunta frmAltaPregunta = new FrmAltaPregunta();
            frmAltaPregunta.Visible = true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FrmBajaPregunta frmBajaPregunta = new FrmBajaPregunta();
            frmBajaPregunta.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPregunta frmModificarPregunta = new FrmModificarPregunta();
            frmModificarPregunta.Visible = true;
        }
    }
}
