﻿using System;
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
