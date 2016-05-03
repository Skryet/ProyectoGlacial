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
                raiz.Siguiente = nuevo;
                nuevo.Anterior = raiz;
                posicion++;
            }
        }

        public materialVenta obtenerVenta(int pos)
        {
            NodoProducto tmp = raiz;
            materialVenta producto = new materialVenta();
            for (int i = 0; i <= posicion; i++)
            {
                if (i == pos)
                {
                    producto = tmp.Producto;
                    break;
                }
                tmp = tmp.Siguiente;
            }
            return producto;
        }
    }
}
