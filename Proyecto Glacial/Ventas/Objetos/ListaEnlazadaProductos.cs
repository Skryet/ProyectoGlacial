using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class ListaEnlazadaProductos
    {
        private NodoProducto raiz;
        private int posicion;

        public ListaEnlazadaProductos()
        {
            raiz = null;
            posicion = 0;
        }

        public void Insertar(NodoProducto nuevo)
        {
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

        public NodoProducto ObtenerLista() { return raiz; }

        public int CantidadElementos() { return posicion; }
         
    }
}
