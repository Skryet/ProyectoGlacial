using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    public class NodoProducto
    {
        private Objetos.ListaMaterial producto;
        private Objetos.NodoProducto siguiente;
        private Objetos.NodoProducto anterior;

        public NodoProducto()
        {
            producto = new ListaMaterial();
            siguiente = null;
            anterior = null;
        }

        public Objetos.ListaMaterial Producto { get { return producto; } set { producto = value; } }
        public Objetos.NodoProducto Siguiente { get { return siguiente; } set { siguiente = value; } }
        public Objetos.NodoProducto Anterior { get { return anterior; } set { anterior = value; } }
    }
}
