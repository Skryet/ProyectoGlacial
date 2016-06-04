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
        private string consulta;

        public generarVenta()
        {
            consulta = "";
        }        

        public void agregarProductos(Objetos.materialVenta producto)
        {
            consulta += "INSERT INTO lista_material_ventas (id_venta, id_producto, cantidad, unidad_medida, precio_unidad, total) VALUES('" +
                    producto.idVenta.ToString() + "','" + producto.idProducto.ToString() + "','" + producto.Cantidad.ToString() + "','" + producto.unidadMedida.ToString() + "','" +
                    producto.precioUnidad.ToString() + "','" + producto.Total.ToString() + "');";

            //Descontar Productos
            consulta += "UPDATE productos SET existencia = '" + producto.Cantidad.ToString() + "' WHERE (id_producto = '" + producto.idProducto.ToString() + "');";
        }

        public void agregarVenta(Objetos.Venta venta)
        {
            consulta += "INSERT INTO ventas (id_cliente, subtotal, descuento, IVA, total, fecha) VALUES('" + 
                venta.idCliente.ToString()+ "', '"+ venta.Subtotal.ToString() +"', '"+ venta.Descuento.ToString() +
                "', '"+ venta.IVA.ToString() +"', '"+ venta.Total.ToString() +"', '"+ venta.Fecha.ToString() +"');";
        }

        public bool ejecutarConsulta()
        {
            int seEjecuto = 0;
            MySqlCommand consultaEjecutar = new MySqlCommand(consulta, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consultaEjecutar.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Venta Realizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool crearVenta(ref int idVenta, int idClienteVenta)
        {
            int seEjecuto = 0;

            MySqlCommand consulta = new MySqlCommand("INSERT INTO ventas (id_cliente) VALUES ('" + idClienteVenta.ToString() + "');", generarConexion.obtenerConexion);
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

            consulta = new MySqlCommand("SELECT MAX(id_venta) AS id FROM ventas;", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                idVenta = lector.GetInt32(0);
            }
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool agregarCliente(int idVenta, int idCliente)
        {
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("UPDATE ventas SET id_cliente = '" + idCliente.ToString() +
                    "' WHERE (id_venta = '" + idVenta.ToString() + "');", generarConexion.obtenerConexion);
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
                MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool borrarVenta(int idVenta)
        {
            int seEjecuto = 0;            
            MySqlCommand consulta = new MySqlCommand("DELETE FROM ventas WHERE id_venta = " + idVenta.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            borrarMaterialVenta(idVenta);

            conexion.cerrarConexion();

            restablecerID(1, "ventas");            

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Venta Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }            
        }       

        public bool borrarMaterialVenta(int idVenta)
        {
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("DELETE FROM lista_material_ventas WHERE id_venta = " + idVenta.ToString() + ";", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            restablecerID(1, "lista_material_ventas");
            conexion.cerrarConexion();            

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Material de Venta Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool borrarPrductosVenta(int idVenta, int idProducto)
        {
            int seEjecuto = 0;
            int cantidad = 0;
           
            //Obtener existencia de producto
            MySqlCommand consulta = new MySqlCommand("SELECT existencia AS id FROM productos WHERE id_producto = '" + idProducto.ToString() + "';", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetString(0) != null)
                {
                    cantidad += lector.GetInt32(0);                    
                }
            }
            conexion.cerrarConexion();

            //Obtener cantidad de lista_material_ventas
            consulta = new MySqlCommand("SELECT cantidad AS id FROM lista_material_ventas WHERE id_producto = '" + idProducto.ToString() + "' AND id_venta = '" + idVenta.ToString() + "' ;", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetString(0) != null)
                {
                    cantidad += lector.GetInt32(0);
                }
            }
            conexion.cerrarConexion();

            //Actualizar existencia en la tabla productos
            consulta = new MySqlCommand("UPDATE productos SET existencia = '" + cantidad.ToString() +
                    "' WHERE (id_producto = '" + idProducto.ToString() + "');", generarConexion.obtenerConexion);
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


            //Eliminar registro de lista_material_venta
            consulta = new MySqlCommand("DELETE FROM lista_material_ventas WHERE id_venta = " + idVenta.ToString() + " AND id_producto = '"+ idProducto.ToString() +"';", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                seEjecuto = consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            restablecerID(1, "lista_material_ventas");
            conexion.cerrarConexion();

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Material de Venta Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool descontarProductos(int cantidad, int idProducto)
        {
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("UPDATE productos SET existencia = '" + cantidad.ToString() +
                    "' WHERE (id_producto = '"+ idProducto.ToString() + "');", generarConexion.obtenerConexion);
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
                MessageBox.Show("Producto descontado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }           
        }

        public bool devolverProductos(int cantidad, int idProducto)
        {
            bool encontrado = false;
            MySqlCommand consulta = new MySqlCommand("SELECT existencia AS id FROM productos WHERE id_producto = '" + idProducto.ToString() + "';", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetString(0) != null)
                {
                    cantidad += lector.GetInt32(0);                    
                    encontrado = true;
                }
            }

            conexion.cerrarConexion();            

            if (encontrado == true)
            {
                int seEjecuto = 0;
                MySqlCommand consultaDevolver = new MySqlCommand("UPDATE productos SET existencia = '" + cantidad.ToString() +
                    "' WHERE (id_producto = '" + idProducto.ToString() + "');", generarConexion.obtenerConexion);
                conexion.abrirConexion();
                try
                {
                    seEjecuto = consultaDevolver.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }

            conexion.cerrarConexion();

            return encontrado;
        }

        public bool agregarProduto(Objetos.materialVenta material)
        {
            int seEjecuto = 0;

            if (comprobarExistente(ref material) == false)
            {
                MySqlCommand consulta = new MySqlCommand("INSERT INTO lista_material_ventas (id_venta, id_producto, cantidad, unidad_medida, precio_unidad, total) VALUES ('" + 
                    material.idVenta.ToString() + "','" + material.idProducto.ToString() + "','" + material.Cantidad.ToString() + "','" + material.unidadMedida.ToString() + "','" +
                    material.precioUnidad.ToString() + "','" + material.Total.ToString() + "');", generarConexion.obtenerConexion);
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
            }

            else
            {
                MySqlCommand consulta = new MySqlCommand("UPDATE lista_material_ventas SET cantidad = '" + material.Cantidad.ToString() + 
                    "', total = '" + material.Total.ToString() + "' WHERE (id_venta = '" + material.idVenta.ToString() + "' AND id_producto = '"
                    + material.idProducto.ToString() + "');", generarConexion.obtenerConexion);
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
            }

            if (seEjecuto != 0)
            {
                MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                return false;
            }           
        }

        public bool comprobarExistente(ref Objetos.materialVenta material)
        {
            bool encontrado = false; 
            MySqlCommand consulta = new MySqlCommand("SELECT cantidad  AS id FROM lista_material_ventas WHERE id_venta = '" + material.idVenta.ToString() + "' AND id_producto = '" + material.idProducto.ToString() + "';", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {                
                if (lector.GetString(0) != null)
                {
                    material.Cantidad += lector.GetInt32(0);
                    material.Total = material.obtenerTotal();
                    encontrado = true;
                }
            }
            conexion.cerrarConexion();

            return encontrado;
        }

        public bool restablecerID(int id, string tabla)
        {                        
            int seEjecuto = 0;
            MySqlCommand consulta = new MySqlCommand("ALTER TABLE clientes AUTO_INCREMENT = 1; ", generarConexion.obtenerConexion);
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
