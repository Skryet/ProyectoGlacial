using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class materialVenta
    {
        private int id_material_ventas;
        private int id_lista_material_ventas;
        private int id_producto;
        private int cantidad;
        private string unidad_medida;
        private double precio_unidad;
        private double total;

        public materialVenta()
        {
            id_lista_material_ventas = 0;
            id_lista_material_ventas = 0;
            id_producto = 0;
            cantidad = 0;
            unidad_medida = "";
            precio_unidad = 0;
            total = 0;
        }

        public int idMaterialVentas { get { return id_material_ventas; } set { id_material_ventas = value; } }

        public int idListaMaterialVentas { get { return id_material_ventas; } set { id_material_ventas = value; } }

        public int idProducto { get { return id_producto; } set { id_producto = value; } }

        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

        public string unidadMedida { get { return unidad_medida; } set { unidad_medida = value; } }

        public double precioUnidad { get { return precioUnidad; } set { precio_unidad = value; } }

        public double Total { get { return total; } set { total = value; } }


    }
}
