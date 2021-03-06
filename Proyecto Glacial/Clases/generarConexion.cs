﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    public class generarConexion
    {
        private static MySqlConnection conexion = new MySqlConnection("server=glacialcolima.ddns.net;user id=SGAglacial;password=Glacial_MASTER16;persistsecurityinfo=True;database=glacial_almacen;Convert Zero Datetime=True");

        bool estadoConexion = false;

        public generarConexion()
        {

        }

        /// <summary>
        /// Abrir conexion con el servidor
        /// </summary>
        /// 
        public void abrirConexion()
        {
            try
            {
                if (estadoConexion == false)
                {
                    conexion.Open();
                    estadoConexion = true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cerrar conexion con el servidor
        /// </summary>
        public void cerrarConexion()
        {
            try
            {
                if (estadoConexion == true)
                {
                    conexion.Close();
                    estadoConexion = false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtener  cadena de conexion
        /// </summary>
        public static MySqlConnection obtenerConexion { get { return conexion; } }

    }
}
