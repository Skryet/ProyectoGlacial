using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class ListaEnlazadaProductos
    {
        private NodoProducto raiz;
        private int posicion;
        private generarConexion conexion = new generarConexion();        

        public ListaEnlazadaProductos()
        {
            raiz = null;
            posicion = 0;
        }

        public void Insertar(NodoProducto nuevo)
        {
            nuevo.Producto.PrecioEstablecido = nuevo.Producto.Precio1;
            if (raiz == null)
            {
                posicion++;
                raiz = nuevo;
            }
            else
            {
                NodoProducto tmp = raiz;
                while (tmp.Siguiente != null)
                    tmp = tmp.Siguiente;
                tmp.Siguiente = nuevo;
                posicion++;
            }
        }

        public NodoProducto obtenerProducto(string idLineaProducto)
        {
            NodoProducto tmp = raiz;
            NodoProducto producto = null;
            for (int i = 0; i < posicion; i++)
            {
                if (tmp.Producto.idLineaProducto == idLineaProducto)
                {
                    producto = new NodoProducto();
                    producto.Producto = tmp.Producto;
                    break;
                }
                tmp = tmp.Siguiente;
            }
            return producto;
        }

        public void AgregarCantidad(int cantidad, string idLineaProducto)
        {
            NodoProducto tmp = raiz;            
            for (int i = 0; i < posicion; i++)
            {
                if (tmp.Producto.idLineaProducto == idLineaProducto)
                {
                    tmp.Producto.Cantidad = cantidad;
                    break;
                }
                tmp = tmp.Siguiente;
            }
        }

        public bool borrarProducto(string idProducto)
        {
            bool borrado = false;
            if (raiz.Producto.idLineaProducto == idProducto)
            {
                raiz = raiz.Siguiente;
                posicion--;
                borrado = true;                
            }
            else
            {
                NodoProducto tmp = raiz;
                for (int i = 0; i < posicion-1; i++)
                {
                    if (tmp.Siguiente.Producto.idLineaProducto == idProducto)
                    {
                        tmp.Siguiente = tmp.Siguiente.Siguiente;
                        posicion--;
                        borrado = true;
                        break;                    
                    }
                    tmp = tmp.Siguiente;
                }
            }
            return borrado;
        }

        public void EstablecerPrecio(double precio, string idLineaProducto)
        {
            NodoProducto tmp = raiz;
            for (int i = 0; i < posicion; i++)
            {
                if (tmp.Producto.idLineaProducto == idLineaProducto)
                {
                    tmp.Producto.PrecioEstablecido = precio;
                    break;
                }
                tmp = tmp.Siguiente;
            }
        }

        public bool ComprobarExistencia(int cantidad, string idLineaProducto)
        {
            bool superaLimite = true;
            NodoProducto tmp = raiz;
            for (int i = 0; i < posicion; i++)
            {
                if (tmp.Producto.idLineaProducto == idLineaProducto)
                {
                    superaLimite = Comprobar(ref tmp, cantidad);
                    break;
                }
                tmp = tmp.Siguiente;
            }

            return superaLimite;
        }

        private bool Comprobar(ref NodoProducto material, int cantidad)
        {
            bool superaLimite = true;
            MySqlCommand consulta = new MySqlCommand("SELECT existencia FROM productos WHERE id_linea_producto = '" + material.Producto.idLineaProducto.ToString() + "';", generarConexion.obtenerConexion);
            conexion.abrirConexion();
            MySqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                if (lector.GetString(0) != null && cantidad <= lector.GetInt32(0))
                {
                    material.Producto.Cantidad = cantidad;
                    superaLimite = false;
                }
            }
            conexion.cerrarConexion();

            return superaLimite;
        }

        public NodoProducto ObtenerLista() { return raiz; }

        public int CantidadElementos() { return posicion; }
         
    }
}
