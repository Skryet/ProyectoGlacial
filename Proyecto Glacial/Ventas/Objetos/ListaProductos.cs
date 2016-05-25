using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class ListaProductos
    {
        private int i;
        private Objetos.materialVenta[] lista;

        public ListaProductos()
        {
            i = 0;
            lista = new materialVenta[100];
        }        

        public void agregarProducto(materialVenta producto)
        {
            bool encontrado = false;
            if (i != 100)
            {
                if (i != 0)
                    encontrado = verificarExistencia(producto);
                
                if (encontrado == false)
                {
                    lista[i] = producto;
                    i++;
                }
            }
            else
                MessageBox.Show("La lista está llena.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool verificarExistencia(materialVenta productoExistencia)
        {
            bool encontrado = false;
            for (int c = 0; c < i; c++)
            {
                if (lista[c].idProducto == productoExistencia.idProducto && lista[c].precioUnidad == productoExistencia.precioUnidad)
                {
                    lista[c].Cantidad += productoExistencia.Cantidad;
                    lista[c].Total = lista[c].obtenerTotal();
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public void eliminarProducto(int idEliminar)
        {
            int posicionEliminar = 0;
            bool ocupaReacomodo = false;
            for (int c = 0; c < i; c++)
            {
                if (lista[c].idProducto == idEliminar)
                {
                    posicionEliminar = c;
                    ocupaReacomodo = true;
                }
            }

            if (ocupaReacomodo == true)
            {
                for (int c = posicionEliminar; c <= i; c++)
                {
                    if (c != 99)
                        lista[c] = lista[c + 1];
                    else
                        lista[c] = null;                    
                }
                lista[i] = null;
                i--;
            }            
        }

        public void modificar(
            int idModificar,
            int id_venta,
            int id_producto,
            int cantidad,
            string unidad_medida,
            double precio_unidad,
            double total,
            string linea,
            string codigo,
            string descripcion)
        {
            lista[idModificar] = new materialVenta();
            lista[idModificar].idVenta = id_venta;
            lista[idModificar].idProducto = id_producto;
            lista[idModificar].Cantidad = cantidad;
            lista[idModificar].unidadMedida = unidad_medida;
            lista[idModificar].precioUnidad = precio_unidad;
            lista[idModificar].Total = lista[i].obtenerTotal();
            lista[idModificar].Linea = linea;
            lista[idModificar].Codigo = codigo;
            lista[idModificar].Descripcion = descripcion;
        }

        public materialVenta[] obtenerLista() { return lista; }

        public int obtenerLargo() { return i; }

        public materialVenta obtenerProducto(int posicion) { return lista[posicion]; }        
    }
}
