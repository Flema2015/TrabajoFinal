using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_
{
    public static class GestorMenu
    {
        // Atributo estático para mantener referencia al menú del formulario MDI
        public static MenuStrip MenuPrincipal { get; set; }

        // Método para ocultar el menú
        public static void OcultarMenu()
        {
            if (MenuPrincipal != null)
            {
                MenuPrincipal.Visible = false;
            }
        }

        // Método para mostrar el menú
        public static void MostrarMenu()
        {
            if (MenuPrincipal != null)
            {
                MenuPrincipal.Visible = true;
            }
        }
    }
}
