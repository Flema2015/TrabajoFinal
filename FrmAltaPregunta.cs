using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace TrabajoFinal_
{
    public partial class FrmAltaPregunta : Form
    {
        List<string> respuestas = new List<string>();
        const int MAX = 4;
        int i = 0;
        int idPregunta = 1;


        public FrmAltaPregunta()
        {
            InitializeComponent();
            // TODO verifica el ultimo id en el archivo.
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta();


            pregunta.PreguntaId = lblIDPregunta.Text;
            pregunta.TxtPregunta = txtPregunta.Text;
            pregunta.ListaDeRespuestas = respuestas;
            string respuesta = txtRespuesta.Text;
            pregunta.RespuestaCorrecta = txtRespuestaCorrecta.Text;
            pregunta.Asignatura = txtAsignatura.Text;
            pregunta.Unidad = txtUnidad.Text;
            pregunta.SubUnidad = txtSubUnidad.Text;
            pregunta.Visible = true;
            validarCampos(pregunta.TxtPregunta, respuesta, pregunta.RespuestaCorrecta, pregunta.Asignatura, pregunta.Unidad, pregunta.SubUnidad);



            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show(
            "¿Desea ingresar otra pregunta antes de cerrar este formulario?",
            "Confirmar cierre",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // Si el usuario selecciona "si", permite ingresar otra pregunta.
            if (resultado == DialogResult.Yes)
            {
                //e.Cancel = true; // Cancelar el evento de cierre

                // borra el contenido de los campos.
                lblIDPregunta.Text = "";
                txtPregunta.Text = "";
                respuestas = null;
                txtRespuesta.Text = "";
                txtRespuestaCorrecta.Text = "";
                txtAsignatura.Text = "";
                txtUnidad.Text = "";
                txtSubUnidad.Text = "";

                idPregunta++;
                lblPreguntaID.Text = idPregunta.ToString();
            }else
            {
                this.Close();
            }


            
        }

        private void btnCargarRespuesta_Click(object sender, EventArgs e)
        {
            //if para dar un maximo de respuestas.
            if (i < 4)
            {
                respuestas.Add(txtRespuesta.Text);
                i++;
                cmbRespuestas.Items.Add(txtRespuesta.Text);
            }
            else
            {
                MessageBox.Show("Se ha cargado el maximo de respuestas");
            }

        }

        private void validarCampos(string Pregunta, string respuesta, string RespuestaCorrecta, string Asignatura, string Unidad, string SubUnidad)
        {
            if (Pregunta == "")
            {
                MessageBox.Show("completar el campo de pregunta");
                return;
            }
            if (respuesta == "")
            {
                MessageBox.Show("completar el campo de respuesta ");
                return;

            }
            if (RespuestaCorrecta == "")
            {
                MessageBox.Show("completar el campo de Respuesta correcta");
                return;

            }
            if (Asignatura == "")
            {
                MessageBox.Show("completar el campo de Asignatura");
                return;
            }
            if (Unidad == "")
            {
                MessageBox.Show("completar el campo de Unidad");
                return;
            }
            if (SubUnidad == "")
            {
                MessageBox.Show("completar el campo de SubUnidad");
                return;
            }
        }

        
    }
}
