using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class ListaMaterial
    {
        private int id_producto;
        private string codigo;
        private string id_linea_producto;
        private string linea_producto_codigo;
        private string nombre;
        private string descripcion;
        private int existencia;
        private string unidad_medida;
        private double precio1;
        private double precio2;
        private double precio3;
        private double precio_especial;

        public ListaMaterial()
        {
            codigo = "";
            nombre = "";
            id_linea_producto = "";
            linea_producto_codigo = "";
            descripcion = "";     
            existencia = 0;
            unidad_medida = "";
            precio1 = 0;
            precio2 = 0;
            precio3 = 0;
            precio_especial = 0;
        }

        public int idProducto { get { return id_producto; } set { id_producto = value; } }
        public string idLineaProducto { get { return id_linea_producto; } set { id_linea_producto = value; } }
        public string LineaProductoCodigo { get { return linea_producto_codigo; } set { linea_producto_codigo = value; } }        
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Existencia { get { return existencia; } set { existencia = value; } }
        public string UnidadMedida { get { return unidad_medida; } set { unidad_medida = value; } }
        public double Precio1 { get { return precio1; } set { precio1 = value; } }
        public double Precio2 { get { return precio2; } set { precio2 = value; } }
        public double Precio3 { get { return precio3; } set { precio3 = value; } }
        public double PrecioEspecial { get { return precio_especial; } set { precio_especial = value; } }
        public string Codigo()
        {
            codigo = id_linea_producto + linea_producto_codigo;
            return codigo;
        }
    }
}
