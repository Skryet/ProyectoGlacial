using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial.Ventas.Consultas
{
    class consultasVentas
    {
        private generarConexion conexion = new generarConexion();
        bool estadoConexion = false;

        public void obtenerNombreCliente(ref string nombreCliente, int idCliente)
        {
            MySqlCommand consulta = new MySqlCommand("SELECT nombre, apellidoP, apellidoM FROM clientes WHERE id_cliente =" + idCliente.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    nombreCliente = lector.GetString(0);
                    nombreCliente += lector.GetString(1);
                    nombreCliente += lector.GetString(2);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }

        public void obtenerNombreEmpresa(ref string nombreEmpresa, int idEmpresa)
        {
            MySqlCommand consulta = new MySqlCommand("SELECT nombre FROM empresa WHERE id_empresa =" + idEmpresa.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    nombreEmpresa = lector.GetString(0);                    
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }
    }
}
