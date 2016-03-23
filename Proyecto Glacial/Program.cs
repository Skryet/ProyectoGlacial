using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    static class Program
    {

        public static int idCliente = 0;
        public static bool isOpenMainClientForm = true;       
        public static int idProveedor;
        public static int idEmpresa;

        //Variables de Ventas
        public static int idComprador = 0;
        public static int idVenta = 0;
        public static int idProductoVenta = 0;
        public static int idListaVenta = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ventas.frm_Ventas());
        }
    }
}
