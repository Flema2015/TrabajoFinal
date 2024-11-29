namespace TrabajoFinal_
{
    public partial class FrmEditorPregunta : Form
    {
        // Propiedad para almacenar el texto escrito en el editor
        public string TextoEscrito { get; private set; } = string.Empty;

        // Propiedad para configurar el texto inicial del editor
        public string TextoInicial
        {
            set { txtEditor.Text = value; } // Al asignar, se inicializa el TextBox
        }

        public FrmEditorPregunta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Almacenar el contenido del TextBox en la propiedad
            TextoEscrito = txtEditor.Text;

            // Establecer el resultado del diálogo como OK y cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Almacenar el texto escrito
            TextoEscrito = txtEditor.Text;

            // Establecer el resultado del diálogo como Cancel y cerrar el formulario
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
