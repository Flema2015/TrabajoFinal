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
    public partial class FrmBajaPregunta : Form
    {
        
        public FrmBajaPregunta()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmBancoDePreguntas frmBancoDePreguntas = new FrmBancoDePreguntas();
            frmBancoDePreguntas.ShowDialog();
        }
    }
}
