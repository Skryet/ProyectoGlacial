using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    static class Program
    {
        public static int idProveedor;
        public static string nombreProveedor;
        public static int idListaProveedorActual;
        public static bool agregarProveedoresProducto = false;

        public static int idCliente;
        public static bool isOpenMainClientForm = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_MenuPrincipal());
        }
    }
}
