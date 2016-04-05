using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial
{
    class generarConexion
    {
        private static MySqlConnection conexion = new MySqlConnection("server=glacialcolima.ddns.net;user id=SGAglacial;password=Glacial_MASTER16;persistsecurityinfo=True;database=glacial_almacen");
        bool estadoConexion = false;

        public generarConexion()
        {

        }

        /// <summary>
        /// Abrir conexion con el servidor
        /// </summary>
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
