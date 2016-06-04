using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class materialVenta
    {        
        private int id_venta;
        private int id_producto;
        private int cantidad;
        private string unidad_medida;
        private double precio_unidad;
        private double total;

        //Variables de vista de DataGrid
        private string linea;
        private string codigo;
        private string descripcion;
        private string nombre;

        public materialVenta()
        {            
            id_venta = 0;
            id_producto = 0;
            cantidad = 0;
            unidad_medida = "";
            precio_unidad = 0;
            total = 0;
            linea = "";
            codigo = "";
            descripcion = "";
            nombre = "";
        }       

        public int idVenta { get { return id_venta; } set { id_venta = value; } }

        public int idProducto { get { return id_producto; } set { id_producto = value; } }

        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

        public string unidadMedida { get { return unidad_medida; } set { unidad_medida = value; } }

        public double precioUnidad { get { return precio_unidad; } set { precio_unidad = value; } }

        public double Total { get { return total; } set { total = value; } }

        public string Linea { get { return linea; } set { linea = value; } }

        public string Codigo { get { return codigo; } set { codigo = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public double obtenerTotal()
        {
            total = precioUnidad * cantidad;
            return total;           
        }

    }
}
