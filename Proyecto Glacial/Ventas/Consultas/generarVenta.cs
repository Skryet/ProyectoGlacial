using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas.Consultas
{
    class generarVenta
    {
        private generarConexion conexion = new generarConexion();


        public bool crearVenta(ref int idVenta, ref int idListaVenta, int idComprador)
        {
            int seEjecuto = 0;

            MySqlCommand consulta = new MySqlCommand("INSERT INTO ventas (id_comprador) VALUES ('" + idComprador + "');", generarConexion.obtenerConexion);
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
                MessageBox.Show("Registro agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;

            consulta = new MySqlCommand("SELECT MAX(id_venta) AS id FROM ventas;", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                idVenta = lector.GetInt32(0);
            }
            conexion.cerrarConexion();

            consulta = new MySqlCommand("INSERT INTO lista_material_ventas (id_venta) VALUES ('" + idVenta.ToString() + "');", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            consulta.ExecuteNonQuery();
            conexion.cerrarConexion();

            consulta = new MySqlCommand("SELECT MAX(id_lista_material_ventas) AS id FROM lista_material_ventas;", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                idListaVenta = lector.GetInt32(0);
            }
            conexion.cerrarConexion();

        }

        public void agregarProduto
    }
}
