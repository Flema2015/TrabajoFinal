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
    public partial class FrmAltaPregunta : Form
    {
        public FrmAltaPregunta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmBancoDePreguntas frmBancoDePreguntas = new FrmBancoDePreguntas();
            frmBancoDePreguntas.ShowDialog();
        }

        private void txtPregunta_MouseClick(object sender, MouseEventArgs e)
        {
            // Crear una instancia del formulario editor
            using (FrmEditorPregunta editor = new FrmEditorPregunta())
            {
                // Pasar el contenido actual del TextBox al editor
                editor.TextoInicial = txtPregunta.Text;

                // Mostrar el editor como un formulario modal
                var result = editor.ShowDialog();

                // Si el usuario presionó "Aceptar", transferir el texto
                if (result == DialogResult.OK)
                {
                    txtPregunta.Text = editor.TextoEscrito;
                }
            }
        }
    }
}
