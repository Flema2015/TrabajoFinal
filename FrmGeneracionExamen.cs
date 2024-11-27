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
    public partial class FrmGeneracionExm : Form
    {
        public FrmGeneracionExm()
        {
            InitializeComponent();
            cmbAsignatura.DataSource = Enum.GetValues(typeof(Asignaturas));
        }

        public enum Asignaturas
        {
            ElegirMateria,
            Programación,
            Matemáticas
        }


    }
}
