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
            }
        }

        public ListaMaterial obtenerProducto (int idProducto)
        {
            NodoProducto tmp = raiz;
            ListaMaterial producto = new ListaMaterial();
            while (tmp.Siguiente != null)
            {
                if (tmp.Producto.idProducto == idProducto)
                {
                    producto = tmp.Producto;
                    break;
                }
                tmp = tmp.Siguiente;
            }
            return producto;
        }

        public bool borrarProducto(int idProducto)
        {
            bool borrado = false;
            if (raiz.Producto.idProducto == idProducto)
            {
                raiz = raiz.Siguiente;
                borrado = true;
            }
            else
            {
                NodoProducto tmp = raiz;
                while (tmp.Siguiente != null)
                {
                    if (tmp.Siguiente.Producto.idProducto == idProducto)
                    {
                        tmp.Siguiente = tmp.Siguiente.Siguiente;
                        borrado = true;
                    }
                }
            }   
            return borrado;
        }

        public NodoProducto ObtenerLista() { return raiz; }
         
    }
}
