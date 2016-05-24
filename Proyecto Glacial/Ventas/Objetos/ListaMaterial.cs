using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    public class ListaMaterial
    {
        private int id_producto;
        private string id_linea_producto;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private string unidad_medida;
        private double precio1;
        private double precio2;
        private double precio3;
        private double precio_especial;
        private double precio_establecido;

        public ListaMaterial()
        {
            nombre = "";
            id_linea_producto = "";
            descripcion = "";     
            cantidad = 0;
            unidad_medida = "";
            precio1 = 0;
            precio2 = 0;
            precio3 = 0;
            precio_especial = 0;
            precio_establecido = 0;
        }

        public int idProducto { get { return id_producto; } set { id_producto = value; } }
        public string idLineaProducto { get { return id_linea_producto; } set { id_linea_producto = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string UnidadMedida { get { return unidad_medida; } set { unidad_medida = value; } }
        public double Precio1 { get { return precio1; } set { precio1 = value; } }
        public double Precio2 { get { return precio2; } set { precio2 = value; } }
        public double Precio3 { get { return precio3; } set { precio3 = value; } }
        public double PrecioEspecial { get { return precio_especial; } set { precio_especial = value; } }    
        public double PrecioEstablecido { get { return precio_establecido; } set { precio_establecido = value; } }    
    }
}
