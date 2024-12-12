using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TrabajoFinal_
{

    public partial class FrmAdministrarAsignatura : Form
    {
        List<Asignatura> asignaturas = new List<Asignatura>();
        const string CARPETA = "files";
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        public FrmAdministrarAsignatura()
        {
            InitializeComponent();

            CargarUnidades();

            asignaturas = CargarAsignatura();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura();
            List<string> lista = new List<string>();

            validarCampos(asignatura.Carrera, asignatura.Nombre);

            if (string.IsNullOrWhiteSpace(cmbUnidades.Text))
            {
                MessageBox.Show("Debes seleccionar una Unidad");
                return;
            }

            asignatura.Carrera = txtCarrera.Text;
            asignatura.Nombre = txtAsginatura.Text;

            foreach (string item in cmbUnidades.Items)
            {
                lista.Add(item);
            }
            asignatura.Unidades = lista;


            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show(
            "¿Desea ingresar otra Asignatura?",
            "Confirmar cierre",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);


            asignaturas.Add(asignatura);
            GuardarAsignaturas(asignaturas);

            if (resultado == DialogResult.Yes)
            {
                txtCarrera.Text = "";
                txtAsginatura.Text = "";
                cmbUnidades.SelectedItem = -1;

            }
            else
            {
                this.Close();
            }
        }
        private void CargarUnidades()
        {
            for (int i = 0; i < 6; i++)
            {
                cmbUnidades.Items.Add((i + 1).ToString());
            }
        }
        private void GuardarAsignaturas(List<Asignatura> asignaturas)
        {
            try
            {
                if (!Directory.Exists(CARPETA))
                {
                    Directory.CreateDirectory(CARPETA);
                    // Crea una lista para almacenar las preguntas en formato JSON
                    var listaAsignaturasJSON = asignaturas.Select(asignatura => new
                    {
                        Carrera = asignatura.Carrera,
                        Nombre = asignatura.Nombre,
                        Unidades = asignatura.Unidades,
                    }).ToList();

                    // Serializa la lista de preguntas al formato JSON
                    string json = JsonSerializer.Serialize(listaAsignaturasJSON, new JsonSerializerOptions { WriteIndented = true });

                    // Escribe el JSON en el archivo
                    File.WriteAllText(rutaArchivoAsignaturas, json);

                    MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
                }
                else
                {
                    string json = JsonSerializer.Serialize(asignaturas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoAsignaturas, json);

                    //maxId = int.Parse(lblPreguntaID.Text);

                    MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos");

            }
        }


        private void validarCampos(string carrera, string asignatura)
        {
            if (carrera == "")
            {
                MessageBox.Show("completar el campo de carrera");
                return;
            }
            if (asignatura == "")
            {
                MessageBox.Show("completar el campo de asignatura ");
                return;

            }

        }

        private List<Asignatura> CargarAsignatura()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();
                return asignaturas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas");
                return null;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdministrarAsignatura_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }
    }
}
