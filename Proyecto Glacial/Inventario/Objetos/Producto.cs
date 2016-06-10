using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Inventario.Objetos
{
    class Producto : Ventas.Objetos.ListaMaterial
    {
        private int linea_producto_codigo;
        private int id_lista_proveedores;
        private string marca_carro;
        private string anio_carro;
        private string modelo_carro;
        private int numero_pedimento;
        private int cantidad_minima;
        private byte[] imagen;

        public int LineaProductoCodigo { get { return linea_producto_codigo; } set { linea_producto_codigo = value; } }
        public int IdListaProveedores { get { return id_lista_proveedores; } set { id_lista_proveedores = value; } }
        public string MarcaCarro { get { return marca_carro; } set { marca_carro = value; } }
        public string AnioCarro { get { return anio_carro; } set { anio_carro = value; } }
        public string ModeloCarro { get { return modelo_carro; } set { modelo_carro = value; } }
        public int NumeroPedimento { get { return numero_pedimento; } set { numero_pedimento = value; } }
        public int CantidadMinima { get { return cantidad_minima; } set { cantidad_minima = value; } }
        public byte[] Imagen { get { return imagen; } set { imagen = value; } }      
    }
}
