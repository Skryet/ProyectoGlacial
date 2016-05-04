using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Proyecto_Glacial.Ventas.Consultas
{
    class GenerarAutocompletado
    {
        private generarConexion conexion = new generarConexion();
        private string consulta;

        public void llenarListaAutocompletar(string buscarNombre, string buscarLinea, string buscarCodigo)
        {

            string comando = "SELECT id_producto, id_linea_producto, linea_producto_codigo, nombre, descripcion, existencia, unidad_medida, precio1, precio2, precio3, precio_especial"
                + "FROM productos WHERE id_linea_producto LIKE '%"+buscarLinea+"%' OR linea_producto_codigo LIKE '%"+buscarCodigo+"%' OR nombre LIKE '"+buscarNombre+"';";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    Objetos.NodoProducto producto = new Objetos.NodoProducto();
                    producto.Producto.idProducto = lector.GetInt32(0);
                    producto.Producto.idLineaProducto = lector.GetString(1);
                    producto.Producto.LineaProductoCodigo = lector.GetString(2):
                    producto.Producto.Nombre = lector.GetString(3);
                    producto.Producto.Descripcion = lector.GetString(4);
                    producto.Producto.Existencia = lector.GetInt32(5);
                    producto.Producto.UnidadMedida = lector.GetString(6);
                    producto.Producto.Precio1 = lector.GetDouble(7);
                    producto.Producto.Precio2 = lector.GetDouble(8);
                    producto.Producto.Precio3 = lector.GetDouble(9);
                    producto.Producto.PrecioEspecial = lector.GetDouble(9);
                    Program.listaProductosAutocompletar.Insertar(producto);
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
