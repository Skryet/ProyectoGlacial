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
        public static int idProveedorCodigo;
        public static int idCompra;
        public static int idListaCompra;

        public static int idProducto;

        public static int idCliente;
        public static bool isOpenMainClientForm = true;

        //Variables de Ventas
        public static int idClienteVenta = 0;
        public static int idEmpresaVenta = 0;
        public static int idVenta = 0;
        public static int idProductoVenta = 0;
        public static bool ventaCreada = false;

        public static optimizar metodosOptimizar = new optimizar();
        //public static int idProveedor;
        public static int idEmpresa;
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
