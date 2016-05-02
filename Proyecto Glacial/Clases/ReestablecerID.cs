using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Clases
{
    class ReestablecerID
    {
        generarConexion conexion = new generarConexion();
        public bool restablecerID(string tabla)
        {
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("ALTER TABLE " + tabla + " AUTO_INCREMENT = 1;" , generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                 seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Se Restablecio el ID", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {               
                return false;
            }
        }
    }
}
