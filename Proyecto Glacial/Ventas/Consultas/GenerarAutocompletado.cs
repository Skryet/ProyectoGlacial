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

        public void llenarListaAutocompletarCodigo(string buscarCodigo)
        {

            string comando = "SELECT id_producto, id_linea_producto, nombre, descripcion, existencia, unidad_medida, precio1, precio2, precio3, precio_especial"
                + " FROM productos WHERE id_linea_producto LIKE '%"+buscarCodigo+"%';";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetInt32(4) > 0)
                    {
                        Objetos.NodoProducto producto = new Objetos.NodoProducto();
                        producto.Producto.idProducto = lector.GetInt32(0);
                        producto.Producto.idLineaProducto = lector.GetString(1);
                        producto.Producto.Nombre = lector.GetString(2);
                        producto.Producto.Descripcion = lector.GetString(3);
                        producto.Producto.Cantidad = lector.GetInt32(4);
                        producto.Producto.UnidadMedida = lector.GetString(5);
                        producto.Producto.Precio1 = lector.GetDouble(6);
                        producto.Producto.Precio2 = lector.GetDouble(7);
                        producto.Producto.Precio3 = lector.GetDouble(8);
                        producto.Producto.PrecioEspecial = lector.GetDouble(9);
                        Program.listaProductosAutocompletar.Insertar(producto);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }

        public void llenarListaAutocompletarDescripcion(string buscarDescripcion)
        {

            string comando = "SELECT id_producto, id_linea_producto, nombre, descripcion, existencia, unidad_medida, precio1, precio2, precio3, precio_especial"
                + " FROM productos WHERE descripcion LIKE '%" + buscarDescripcion + "%';";
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
                    producto.Producto.Nombre = lector.GetString(2);
                    producto.Producto.Descripcion = lector.GetString(3);
                    producto.Producto.Cantidad = lector.GetInt32(4);
                    producto.Producto.UnidadMedida = lector.GetString(5);
                    producto.Producto.Precio1 = lector.GetDouble(6);
                    producto.Producto.Precio2 = lector.GetDouble(7);
                    producto.Producto.Precio3 = lector.GetDouble(8);
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
